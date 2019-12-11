using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    InputBuffer _inputBuffer;
    PlayerMovement _playerMovement;
    Animator _animator;

    private void Awake()
    {
        _inputBuffer = GetComponent<InputBuffer>();
        _playerMovement = GetComponent<PlayerMovement>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Watch if animation state == ready (idle o lo que sea)

        // input buffer.GetNextAction();
        // Start next action
        // TODO: Give the actions IStartable to start them directly


        if (_inputBuffer.GetNextAction() == "g")
        {
            Debug.Log("Started animation Attacking");
            _animator.SetBool("Attacking", true);
        }
    }

    public void AlertObservers(string message)
    {
        _animator.SetBool("Attacking", false);
    }

    public void ShootEvent()
    {
        _playerMovement.Shoot();
        _animator.SetBool("Attacking", false);
    }
}