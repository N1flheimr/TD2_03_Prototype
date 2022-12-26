//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/PlayerMovement.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerMovement : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerMovement()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerMovement"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""f94e97a6-3430-4425-8a8b-096a6d7645d2"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""711bcfeb-e833-4173-b24c-33a2e24e0d45"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""3962b089-6ec2-455c-89bc-ab774bda8684"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3838c9a6-9258-408e-87f2-1102cd3c0302"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""910c653b-97ac-41fb-a855-4319a22c2513"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f59f5b2e-8226-4aed-a64d-019ce6148347"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cc1eda41-c300-4f6b-9a21-f0483e5f3cc9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow"",
                    ""id"": ""d321ac04-f968-4e3a-b9f0-a22740028052"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a36a5798-e8da-416d-87d4-a3508a813e7f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d42802ff-b9a7-47c6-a1c0-cfdd634c8617"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3a45f9e0-9142-4e5c-9563-ba8eb05b043e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a30ff19b-96ac-4959-bd0e-30e46f64ec4a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""StartAction"",
            ""id"": ""b42e7b5f-3159-40f5-91e8-eda9d4201d7c"",
            ""actions"": [
                {
                    ""name"": ""RotateTiles"",
                    ""type"": ""PassThrough"",
                    ""id"": ""062e70e9-4cd7-4a74-bc04-7642a0d137a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ConnectTiles"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bbd3192b-066d-4b78-b573-0df034d473eb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ConnectAllTiles"",
                    ""type"": ""Button"",
                    ""id"": ""13d07d91-ae5b-4c01-8958-1d6407ba84b4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6c989d4a-608c-4bed-b61c-37f13f33639a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateTiles"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63df4831-5d73-4321-8888-c26c5409315f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ConnectTiles"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86edc0c7-95f1-4152-8346-0abe490fa8e4"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ConnectAllTiles"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_Movement = m_Main.FindAction("Movement", throwIfNotFound: true);
        // StartAction
        m_StartAction = asset.FindActionMap("StartAction", throwIfNotFound: true);
        m_StartAction_RotateTiles = m_StartAction.FindAction("RotateTiles", throwIfNotFound: true);
        m_StartAction_ConnectTiles = m_StartAction.FindAction("ConnectTiles", throwIfNotFound: true);
        m_StartAction_ConnectAllTiles = m_StartAction.FindAction("ConnectAllTiles", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Main
    private readonly InputActionMap m_Main;
    private IMainActions m_MainActionsCallbackInterface;
    private readonly InputAction m_Main_Movement;
    public struct MainActions
    {
        private @PlayerMovement m_Wrapper;
        public MainActions(@PlayerMovement wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Main_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void SetCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_MainActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public MainActions @Main => new MainActions(this);

    // StartAction
    private readonly InputActionMap m_StartAction;
    private IStartActionActions m_StartActionActionsCallbackInterface;
    private readonly InputAction m_StartAction_RotateTiles;
    private readonly InputAction m_StartAction_ConnectTiles;
    private readonly InputAction m_StartAction_ConnectAllTiles;
    public struct StartActionActions
    {
        private @PlayerMovement m_Wrapper;
        public StartActionActions(@PlayerMovement wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotateTiles => m_Wrapper.m_StartAction_RotateTiles;
        public InputAction @ConnectTiles => m_Wrapper.m_StartAction_ConnectTiles;
        public InputAction @ConnectAllTiles => m_Wrapper.m_StartAction_ConnectAllTiles;
        public InputActionMap Get() { return m_Wrapper.m_StartAction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(StartActionActions set) { return set.Get(); }
        public void SetCallbacks(IStartActionActions instance)
        {
            if (m_Wrapper.m_StartActionActionsCallbackInterface != null)
            {
                @RotateTiles.started -= m_Wrapper.m_StartActionActionsCallbackInterface.OnRotateTiles;
                @RotateTiles.performed -= m_Wrapper.m_StartActionActionsCallbackInterface.OnRotateTiles;
                @RotateTiles.canceled -= m_Wrapper.m_StartActionActionsCallbackInterface.OnRotateTiles;
                @ConnectTiles.started -= m_Wrapper.m_StartActionActionsCallbackInterface.OnConnectTiles;
                @ConnectTiles.performed -= m_Wrapper.m_StartActionActionsCallbackInterface.OnConnectTiles;
                @ConnectTiles.canceled -= m_Wrapper.m_StartActionActionsCallbackInterface.OnConnectTiles;
                @ConnectAllTiles.started -= m_Wrapper.m_StartActionActionsCallbackInterface.OnConnectAllTiles;
                @ConnectAllTiles.performed -= m_Wrapper.m_StartActionActionsCallbackInterface.OnConnectAllTiles;
                @ConnectAllTiles.canceled -= m_Wrapper.m_StartActionActionsCallbackInterface.OnConnectAllTiles;
            }
            m_Wrapper.m_StartActionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RotateTiles.started += instance.OnRotateTiles;
                @RotateTiles.performed += instance.OnRotateTiles;
                @RotateTiles.canceled += instance.OnRotateTiles;
                @ConnectTiles.started += instance.OnConnectTiles;
                @ConnectTiles.performed += instance.OnConnectTiles;
                @ConnectTiles.canceled += instance.OnConnectTiles;
                @ConnectAllTiles.started += instance.OnConnectAllTiles;
                @ConnectAllTiles.performed += instance.OnConnectAllTiles;
                @ConnectAllTiles.canceled += instance.OnConnectAllTiles;
            }
        }
    }
    public StartActionActions @StartAction => new StartActionActions(this);
    public interface IMainActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IStartActionActions
    {
        void OnRotateTiles(InputAction.CallbackContext context);
        void OnConnectTiles(InputAction.CallbackContext context);
        void OnConnectAllTiles(InputAction.CallbackContext context);
    }
}
