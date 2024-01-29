//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input/PlayerActions.inputactions
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

public partial class @PlayerActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""gameplay"",
            ""id"": ""556b83be-37c8-40cc-bc9f-f1f09188276b"",
            ""actions"": [
                {
                    ""name"": ""SuctionLeft"",
                    ""type"": ""Button"",
                    ""id"": ""d0d88984-ccae-4f64-bc94-2a14783a9440"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SuctionRight"",
                    ""type"": ""Button"",
                    ""id"": ""4a496ccf-7558-4f89-9c77-20a5df1c0f9b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Value"",
                    ""id"": ""6e73083b-45f5-44fb-a696-427b16f52a7d"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Value"",
                    ""id"": ""75b9e478-a666-4e19-9936-4bec5b3053f2"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b98191a0-10aa-4598-a9d8-797fa6a89ecd"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SuctionLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4547a612-cfd3-4fe4-b621-755420362a6c"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Hold(duration=1.401298E-45)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SuctionRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1eb28c4a-63e7-4d68-87b3-359630f02763"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a3a4ecf-9a5a-4e92-8da4-c1645e445dbe"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // gameplay
        m_gameplay = asset.FindActionMap("gameplay", throwIfNotFound: true);
        m_gameplay_SuctionLeft = m_gameplay.FindAction("SuctionLeft", throwIfNotFound: true);
        m_gameplay_SuctionRight = m_gameplay.FindAction("SuctionRight", throwIfNotFound: true);
        m_gameplay_MoveLeft = m_gameplay.FindAction("MoveLeft", throwIfNotFound: true);
        m_gameplay_MoveRight = m_gameplay.FindAction("MoveRight", throwIfNotFound: true);
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

    // gameplay
    private readonly InputActionMap m_gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_gameplay_SuctionLeft;
    private readonly InputAction m_gameplay_SuctionRight;
    private readonly InputAction m_gameplay_MoveLeft;
    private readonly InputAction m_gameplay_MoveRight;
    public struct GameplayActions
    {
        private @PlayerActions m_Wrapper;
        public GameplayActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @SuctionLeft => m_Wrapper.m_gameplay_SuctionLeft;
        public InputAction @SuctionRight => m_Wrapper.m_gameplay_SuctionRight;
        public InputAction @MoveLeft => m_Wrapper.m_gameplay_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_gameplay_MoveRight;
        public InputActionMap Get() { return m_Wrapper.m_gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @SuctionLeft.started += instance.OnSuctionLeft;
            @SuctionLeft.performed += instance.OnSuctionLeft;
            @SuctionLeft.canceled += instance.OnSuctionLeft;
            @SuctionRight.started += instance.OnSuctionRight;
            @SuctionRight.performed += instance.OnSuctionRight;
            @SuctionRight.canceled += instance.OnSuctionRight;
            @MoveLeft.started += instance.OnMoveLeft;
            @MoveLeft.performed += instance.OnMoveLeft;
            @MoveLeft.canceled += instance.OnMoveLeft;
            @MoveRight.started += instance.OnMoveRight;
            @MoveRight.performed += instance.OnMoveRight;
            @MoveRight.canceled += instance.OnMoveRight;
        }

        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @SuctionLeft.started -= instance.OnSuctionLeft;
            @SuctionLeft.performed -= instance.OnSuctionLeft;
            @SuctionLeft.canceled -= instance.OnSuctionLeft;
            @SuctionRight.started -= instance.OnSuctionRight;
            @SuctionRight.performed -= instance.OnSuctionRight;
            @SuctionRight.canceled -= instance.OnSuctionRight;
            @MoveLeft.started -= instance.OnMoveLeft;
            @MoveLeft.performed -= instance.OnMoveLeft;
            @MoveLeft.canceled -= instance.OnMoveLeft;
            @MoveRight.started -= instance.OnMoveRight;
            @MoveRight.performed -= instance.OnMoveRight;
            @MoveRight.canceled -= instance.OnMoveRight;
        }

        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayActions @gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnSuctionLeft(InputAction.CallbackContext context);
        void OnSuctionRight(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
    }
}
