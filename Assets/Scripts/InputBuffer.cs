using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InputBuffer : MonoBehaviour
{
    public List<string> InputValues { get; set; }

    public int CountLimit { get; set; } = 3;

    public InputBuffer()
    {
        InputValues = new List<string>();
    }

    PlayerManager _playerManager;

    public PlayerInputActions controls;

    void Awake()
    {
        // TODO: Continue here https://www.youtube.com/watch?v=s7EIp-OqVyk
        // https://docs.unity3d.com/Manual/class-Transition.html
        // https://forum.unity.com/threads/get-parameter-from-the-animator.202938/
        // https://docs.unity3d.com/ScriptReference/StateMachineBehaviour.html
        // https://docs.unity3d.com/Manual/script-AnimationWindowEvent.html

        _playerManager = GetComponent<PlayerManager>();
        
        controls = new PlayerInputActions();

        controls.StarshipControls.Shoot.performed += ctx => Add("Attacking");
        //controls.StarshipControls.Shoot.canceled += ctx => _animator.SetBool("Attacking", false);


        ///////////////

        //controls.StarshipControls.Move.performed += ctx => { moveX = ctx.ReadValue<Vector2>().x; moveY = ctx.ReadValue<Vector2>().y; };
        //controls.StarshipControls.Aim.performed += ctx => { aimX = ctx.ReadValue<Vector2>().x; aimY = ctx.ReadValue<Vector2>().y; };

        //controls.StarshipControls.Boost.started += ctx => { Boost(true); };
        //controls.StarshipControls.Boost.canceled += ctx => { Boost(false); };

        //controls.StarshipControls.Break.started += ctx => { Break(true); };
        //controls.StarshipControls.Break.canceled += ctx => { Break(false); };

        ///////////////

        //controls.StarshipControls.LeanLeft.performed += ctx => { rotatingSpeed = ctx.ReadValue<float>(); };
        //controls.StarshipControls.LeanLeft.canceled += ctx => { rotatingSpeed = 0; leaningAngle = 0; };

        //controls.StarshipControls.LeanRight.performed += ctx => { Shoot(); };

        //controls.StarshipControls.LeanRight.performed += ctx => { rotatingSpeed = -ctx.ReadValue<float>(); };
        //controls.StarshipControls.LeanRight.canceled += ctx => { rotatingSpeed = 0; leaningAngle = 0; };

        controls.Enable();
    }

    public void Add(string lastInput)
    {
        if (InputValues == null) InputValues = new List<string>();

        foreach (var command in lastInput)
        {
            if (InputValues.Count == CountLimit) InputValues.RemoveAt(0);

            InputValues.Add(command.ToString());
        }
    }

    public string GetNextAction()
    {
        if (InputValues.Count <= 0) return null;

        var value = InputValues.Last();
        InputValues = new List<string>();
        return value;
    }
}
