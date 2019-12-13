using UnityEngine;
using DG.Tweening;
using Cinemachine;
using UnityEngine.Rendering.PostProcessing;

public interface IPlayerMovement
{
    float moveX { get; set; }
    float moveY { get; set; }

    float RotatingSpeed { get; set; }
    float LeaningAngle { get; set; }
    
    void ResetRotation();
}

public class PlayerMovement : MonoBehaviour, IPlayerMovement
{
    private Transform playerModel;
    public GameObject projectile;
    public Transform aimObject; 

    [Header("Settings")]
    public bool joystick = false;

    [Space]

    [Header("Parameters")]
    public float xySpeed = 18;
    public float lookSpeed = 250;
    public float forwardSpeed = 6;
    public float rollingSpeed = 4f;
    public float maxLeaningAnglePerFrame = 30f;

    [Space]

    [Header("Public References")]
    public Transform aimTarget;
    public CinemachineDollyCart dolly;
    public Transform cameraParent;

    [Space]

    [Header("Particles")]
    public ParticleSystem trail;
    public ParticleSystem circle;
    public ParticleSystem barrel;
    public ParticleSystem stars;


    /////////////////////////////////////////////////////////

    public float RotatingSpeed { get; set; }
    public float LeaningAngle { get; set; }

    /////////////////////////////////////////////////////////

    private float _moveX;
    public float moveX
    {
        get { return _moveX; }
        set { _moveX = value; }
    }

    private float _moveY;
    public float moveY
    {
        get { return _moveY; }
        set { _moveY = value; }
    }

    /////////////////////////////////////////////////////////

    private bool boosting;
    private bool breaking;

    /////////////////////////////////////////////////////////

    void Start()
    {
        playerModel = transform.GetChild(0);
        SetSpeed(forwardSpeed);
    }

    void Update()
    {
        //if (Input.GetKey(KeyCode.Escape))
        //    Cursor.lockState = CursorLockMode.None;
        //else
        //    Cursor.lockState = CursorLockMode.Locked;

        //float h = joystick ? Input.GetAxis("Horizontal") : Input.GetAxis("Mouse X");
        //float v = joystick ? Input.GetAxis("Vertical") : Input.GetAxis("Mouse Y");

        Move(moveX, moveY);
        Lean();
    }

    public void Move(float h, float v)
    {
        LocalMove(h, v, xySpeed);
        RotationLook(h, v, lookSpeed);
    }

    void Lean()
    {
        Debug.Log("Rotating Speed: " + RotatingSpeed.ToString());
        Debug.Log("Leaning Angle: " + LeaningAngle.ToString());

        if (RotatingSpeed == 0)
        {
            ResetLeaning();
            return;
        }
        else if (Mathf.Abs(RotatingSpeed) < 0.1)
        {
            return;
        }

        LeaningAngle += RotatingSpeed * rollingSpeed;
        //LeaningAngle = LeaningAngle % 360;
        //LeaningAngle = LeaningAngle < maxLeaningAnglePerFrame ? LeaningAngle : maxLeaningAnglePerFrame;


        if (RotatingSpeed != 0) HorizontalLean(playerModel, LeaningAngle);
    }

    void ResetLeaning()
    {
        HorizontalLeanLerp(playerModel, 0, 0.05f);
    }

    void LocalMove(float x, float y, float speed)
    {
        transform.localPosition += new Vector3(x, y, 0) * speed * Time.deltaTime;
        ClampPosition();
    }

    void ClampPosition()
    {
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }

    void RotationLook(float h, float v, float speed)
    {
        var rotationClamp = 0.5f;

        h = Mathf.Clamp(h, -rotationClamp, rotationClamp);
        v = Mathf.Clamp(v, -rotationClamp, rotationClamp);

        aimTarget.parent.position = Vector3.zero;
        aimTarget.localPosition = new Vector3(h, v, 1);


        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(aimTarget.position), Mathf.Deg2Rad * speed * Time.deltaTime);
    }

    void HorizontalLean(Transform target, float axis)
    {
        Vector3 targetEulerAngels = target.localEulerAngles;
        target.localEulerAngles = new Vector3(targetEulerAngels.x, targetEulerAngels.y, axis);
    }

    void HorizontalLeanLerp(Transform target, float axis, float lerpTime)
    {
        Vector3 targetEulerAngels = target.localEulerAngles;
        target.localEulerAngles = new Vector3(targetEulerAngels.x, targetEulerAngels.y, Mathf.LerpAngle(targetEulerAngels.z, axis, lerpTime));
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(aimTarget.position, .5f);
        Gizmos.DrawSphere(aimTarget.position, .15f);
    }

    public void Roll(int direction)
    {
        if (!DOTween.IsTweening(playerModel))
        {
            playerModel.DOLocalRotate(new Vector3(playerModel.localEulerAngles.x, playerModel.localEulerAngles.y, 360 * -direction), .4f, RotateMode.LocalAxisAdd).SetEase(Ease.OutSine);
            barrel.Play();
        }
    }

    void SetSpeed(float x)
    {
        dolly.m_Speed = x;
    }

    void SetCameraZoom(float zoom, float duration)
    {
        cameraParent.DOLocalMove(new Vector3(0, 0, zoom), duration);
    }

    void DistortionAmount(float x)
    {
        Camera.main.GetComponent<PostProcessVolume>().profile.GetSetting<LensDistortion>().intensity.value = x;
    }

    void FieldOfView(float fov)
    {
        cameraParent.GetComponentInChildren<CinemachineVirtualCamera>().m_Lens.FieldOfView = fov;
    }

    void Chromatic(float x)
    {
        Camera.main.GetComponent<PostProcessVolume>().profile.GetSetting<ChromaticAberration>().intensity.value = x;
    }


    public void Boost(bool state)
    {

        if (state)
        {
            cameraParent.GetComponentInChildren<CinemachineImpulseSource>().GenerateImpulse();
            trail.Play();
            circle.Play();
        }
        else
        {
            trail.Stop();
            circle.Stop();
        }
        trail.GetComponent<TrailRenderer>().emitting = state;

        float origFov = state ? 40 : 55;
        float endFov = state ? 55 : 40;
        float origChrom = state ? 0 : 1;
        float endChrom = state ? 1 : 0;
        float origDistortion = state ? 0 : -30;
        float endDistorton = state ? -30 : 0;
        float starsVel = state ? -20 : -1;
        float speed = state ? forwardSpeed * 2 : forwardSpeed;
        float zoom = state ? -7 : 0;

        DOVirtual.Float(origChrom, endChrom, .5f, Chromatic);
        DOVirtual.Float(origFov, endFov, .5f, FieldOfView);
        DOVirtual.Float(origDistortion, endDistorton, .5f, DistortionAmount);
        var pvel = stars.velocityOverLifetime;
        pvel.z = starsVel;

        DOVirtual.Float(dolly.m_Speed, speed, .15f, SetSpeed);
        SetCameraZoom(zoom, .4f);
    }

    public void Break(bool state)
    {
        float speed = state ? forwardSpeed / 3 : forwardSpeed;
        float zoom = state ? 3 : 0;

        DOVirtual.Float(dolly.m_Speed, speed, .15f, SetSpeed);
        SetCameraZoom(zoom, .4f);
    }

    public void Shoot()
    {
        var bullet = Instantiate(projectile, aimObject.position, aimObject.rotation);
        var bulletRB = bullet.GetComponent<Rigidbody>();
        bulletRB.AddForce(aimObject.transform.forward * 5000);
    }

    public void ResetRotation()
    {
        RotatingSpeed = 0f;
        LeaningAngle = 0f;
    }
}
