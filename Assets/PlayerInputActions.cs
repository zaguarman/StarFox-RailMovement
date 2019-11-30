// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Starship Controls"",
            ""id"": ""2740db37-bd75-4cb7-84d7-287546d172b4"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ecb1318d-7e68-45a6-836d-b2c7ae123ced"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Value"",
                    ""id"": ""53933381-a9b0-444e-a34a-bfb9639fc181"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Value"",
                    ""id"": ""3513e685-bf78-4309-a289-33030f8adfdb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Break"",
                    ""type"": ""Value"",
                    ""id"": ""10393c55-a8d0-49f3-851e-f29ffacd91f9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Lean Left"",
                    ""type"": ""Value"",
                    ""id"": ""4b167309-5ba9-4214-8050-696a830e368d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Lean Right"",
                    ""type"": ""Value"",
                    ""id"": ""a8ce02dd-c6ee-4768-9fda-a54bbd107995"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""17839b8e-aa58-4872-8a5e-bf60561c1058"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e63edecf-2dd2-4b38-b1a1-49889df4f76b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c23f3a43-019a-4cef-8d99-f2dcd9f23b5b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fd3c6781-92fc-46cf-b8f5-13d9c8816b69"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""92b80560-2053-4e0d-9c03-0934f66250e0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7a590705-e214-4107-b6d4-015f4b7a91b6"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb54b731-4f14-4cfa-b29a-61bbcb162c5b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90859376-89aa-422a-89aa-7ed21e68ec6a"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a72c327-7bfa-40c0-9d8d-6a0c2ddb8cc7"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0524e28-bdaa-4f41-9b9b-c2f2f92eb027"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49d28769-2fb0-41b0-b8db-8a13cabbdd93"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""642ae48f-8cda-4bbf-a549-1a6e20e81dd9"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""547aeff2-bd86-4f28-af1f-a95a66f943ba"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Lean Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""501dff37-b693-4f01-bde2-c8d9f0f234b3"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lean Left"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b8edb77-8e34-492d-a370-ba8cced5afb8"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Lean Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13d6debe-c168-499c-9aed-3dd562faad25"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Lean Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Starship Controls
        m_StarshipControls = asset.FindActionMap("Starship Controls", throwIfNotFound: true);
        m_StarshipControls_Move = m_StarshipControls.FindAction("Move", throwIfNotFound: true);
        m_StarshipControls_Shoot = m_StarshipControls.FindAction("Shoot", throwIfNotFound: true);
        m_StarshipControls_Boost = m_StarshipControls.FindAction("Boost", throwIfNotFound: true);
        m_StarshipControls_Break = m_StarshipControls.FindAction("Break", throwIfNotFound: true);
        m_StarshipControls_LeanLeft = m_StarshipControls.FindAction("Lean Left", throwIfNotFound: true);
        m_StarshipControls_LeanRight = m_StarshipControls.FindAction("Lean Right", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Starship Controls
    private readonly InputActionMap m_StarshipControls;
    private IStarshipControlsActions m_StarshipControlsActionsCallbackInterface;
    private readonly InputAction m_StarshipControls_Move;
    private readonly InputAction m_StarshipControls_Shoot;
    private readonly InputAction m_StarshipControls_Boost;
    private readonly InputAction m_StarshipControls_Break;
    private readonly InputAction m_StarshipControls_LeanLeft;
    private readonly InputAction m_StarshipControls_LeanRight;
    public struct StarshipControlsActions
    {
        private @PlayerInputActions m_Wrapper;
        public StarshipControlsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_StarshipControls_Move;
        public InputAction @Shoot => m_Wrapper.m_StarshipControls_Shoot;
        public InputAction @Boost => m_Wrapper.m_StarshipControls_Boost;
        public InputAction @Break => m_Wrapper.m_StarshipControls_Break;
        public InputAction @LeanLeft => m_Wrapper.m_StarshipControls_LeanLeft;
        public InputAction @LeanRight => m_Wrapper.m_StarshipControls_LeanRight;
        public InputActionMap Get() { return m_Wrapper.m_StarshipControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(StarshipControlsActions set) { return set.Get(); }
        public void SetCallbacks(IStarshipControlsActions instance)
        {
            if (m_Wrapper.m_StarshipControlsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_StarshipControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_StarshipControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_StarshipControlsActionsCallbackInterface.OnMove;
                @Shoot.started -= m_Wrapper.m_StarshipControlsActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_StarshipControlsActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_StarshipControlsActionsCallbackInterface.OnShoot;
                @Boost.started -= m_Wrapper.m_StarshipControlsActionsCallbackInterface.OnBoost;
                @Boost.performed -= m_Wrapper.m_StarshipControlsActionsCallbackInterface.OnBoost;
                @Boost.canceled -= m_Wrapper.m_StarshipControlsActionsCallbackInterface.OnBoost;
                @Break.started -= m_Wrapper.m_StarshipControlsActionsCallbackInterface.OnBreak;
                @Break.performed -= m_Wrapper.m_StarshipControlsActionsCallbackInterface.OnBreak;
                @Break.canceled -= m_Wrapper.m_StarshipControlsActionsCallbackInterface.OnBreak;
                @LeanLeft.started -= m_Wrapper.m_StarshipControlsActionsCallbackInterface.OnLeanLeft;
                @LeanLeft.performed -= m_Wrapper.m_StarshipControlsActionsCallbackInterface.OnLeanLeft;
                @LeanLeft.canceled -= m_Wrapper.m_StarshipControlsActionsCallbackInterface.OnLeanLeft;
                @LeanRight.started -= m_Wrapper.m_StarshipControlsActionsCallbackInterface.OnLeanRight;
                @LeanRight.performed -= m_Wrapper.m_StarshipControlsActionsCallbackInterface.OnLeanRight;
                @LeanRight.canceled -= m_Wrapper.m_StarshipControlsActionsCallbackInterface.OnLeanRight;
            }
            m_Wrapper.m_StarshipControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Boost.started += instance.OnBoost;
                @Boost.performed += instance.OnBoost;
                @Boost.canceled += instance.OnBoost;
                @Break.started += instance.OnBreak;
                @Break.performed += instance.OnBreak;
                @Break.canceled += instance.OnBreak;
                @LeanLeft.started += instance.OnLeanLeft;
                @LeanLeft.performed += instance.OnLeanLeft;
                @LeanLeft.canceled += instance.OnLeanLeft;
                @LeanRight.started += instance.OnLeanRight;
                @LeanRight.performed += instance.OnLeanRight;
                @LeanRight.canceled += instance.OnLeanRight;
            }
        }
    }
    public StarshipControlsActions @StarshipControls => new StarshipControlsActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IStarshipControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
        void OnBreak(InputAction.CallbackContext context);
        void OnLeanLeft(InputAction.CallbackContext context);
        void OnLeanRight(InputAction.CallbackContext context);
    }
}
