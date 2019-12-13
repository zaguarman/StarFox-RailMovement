using System.Collections;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    InputBuffer _inputBuffer;
    PlayerMovement _playerMovement;
    Animator _animator;
    PlayerInputActions _controls;
    bool _attacking;

    GameObject _player;

    private void Awake()
    {
        _player = GameObject.Find("Player");

        _controls = new PlayerInputActions();
        _animator = GetComponent<Animator>();
        _playerMovement = GetComponent<PlayerMovement>();
        _inputBuffer = this.gameObject.AddComponent(typeof(InputBuffer)) as InputBuffer;
        _inputBuffer.Initialize(_controls, _playerMovement);
        _controls.Enable();
    }

    private void Update()
    {
        // TODO: Give the actions IStartable to start them directly
        if(!_attacking) {
            if (_inputBuffer.GetNext() == "Attacking")
            {
                Debug.Log("Started animation Attacking");
                Attack();
            }
        }
    }

    void Attack()
    {
        _animator.SetBool("Attacking", true);
        StartCoroutine(Attacking());
    }

    IEnumerator Attacking()
    {
        if (_attacking) yield break;
        
        _attacking = true;
        _playerMovement.Shoot();

        yield return new WaitForSeconds(0.5f);

        _attacking = false;
        _animator.SetBool("Attacking", false);
    }
}