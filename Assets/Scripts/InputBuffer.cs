using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public interface IInputBuffer
{
    void Add(string command);
    string GetNext();
}

public class InputBuffer : MonoBehaviour, IInputBuffer
{
    public List<string> InputValues { get; set; }

    public int CountLimit { get; set; } = 3;

    public PlayerInputActions _controls;
    private IPlayerMovement _playerMovement;

    public void Initialize(PlayerInputActions controls, IPlayerMovement playerMovement)
    {
        _controls = controls;
        _playerMovement = playerMovement;
        InputValues = new List<string>();
        BindInputs();
    }

    void BindInputs()
    {
        _controls.StarshipControls.Shoot.performed += ctx => Add("Attacking");
        //controls.StarshipControls.Shoot.canceled += ctx => _animator.SetBool("Attacking", false);

        //_controls.StarshipControls.Move.performed += ctx => {  moveX = ctx.ReadValue<Vector2>().x; moveY = ctx.ReadValue<Vector2>().y; };
        _controls.StarshipControls.Move.performed += ctx => { _playerMovement.moveX = ctx.ReadValue<Vector2>().x; _playerMovement.moveY = ctx.ReadValue<Vector2>().y; };
        //_controls.StarshipControls.Aim.performed += ctx => { aimX = ctx.ReadValue<Vector2>().x; aimY = ctx.ReadValue<Vector2>().y; };


        //controls.StarshipControls.Boost.started += ctx => { Boost(true); };
        //controls.StarshipControls.Boost.canceled += ctx => { Boost(false); };

        //controls.StarshipControls.Break.started += ctx => { Break(true); };
        //controls.StarshipControls.Break.canceled += ctx => { Break(false); };

        _controls.StarshipControls.LeanRight.performed += ctx => { _playerMovement.RotatingSpeed = ctx.ReadValue<float>(); };
        _controls.StarshipControls.LeanRight.canceled += ctx => { _playerMovement.ResetRotation(); };

        _controls.StarshipControls.LeanLeft.performed += ctx => { _playerMovement.RotatingSpeed = -ctx.ReadValue<float>(); };
        _controls.StarshipControls.LeanLeft.canceled += ctx => { _playerMovement.ResetRotation(); };
    }

    void Awake()
    {
        // TODO: Continue here https://www.youtube.com/watch?v=s7EIp-OqVyk
        // https://docs.unity3d.com/Manual/class-Transition.html
        // https://forum.unity.com/threads/get-parameter-from-the-animator.202938/
        // https://docs.unity3d.com/ScriptReference/StateMachineBehaviour.html
        // https://docs.unity3d.com/Manual/script-AnimationWindowEvent.html
    }

    public void Add(string lastInput)
    {
        if (InputValues == null) InputValues = new List<string>();

        if (InputValues.Count == CountLimit) InputValues.RemoveAt(0);
        InputValues.Add(lastInput);
        Debug.Log(lastInput.ToString());
    }

    public string GetNext()
    {
        if (InputValues.Count <= 0) return null;

        var value = InputValues.Last();
        InputValues.RemoveAt(InputValues.Count-1);
        //InputValues = new List<string>();

        return value;
    }
}
