// GENERATED AUTOMATICALLY FROM 'Assets/Native/Scripts/Core/Input/Input Scheme.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputScheme : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputScheme()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input Scheme"",
    ""maps"": [
        {
            ""name"": ""User"",
            ""id"": ""1867e16d-4053-477e-9bf6-24273eca5c6d"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c5cc6985-7b07-49f7-b323-5d873f93104f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""f5b6c702-35f9-47ea-a826-10a0bf8f4c9f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""da1ec3fa-2bc5-4cd7-b437-3d1415629715"",
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
                    ""id"": ""493365be-8c44-4b80-a7b3-a6a7667a881c"",
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
                    ""id"": ""e98b764e-cb27-47b6-a235-9c57e4455338"",
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
                    ""id"": ""a3930542-9540-4d31-b230-4483ce7be08f"",
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
                    ""id"": ""0382cdaf-41d5-4f91-9010-ed92db358072"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7e3e2400-72aa-41c0-9796-bde5283f346b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""cf64a376-4987-4695-8a1b-2d7e0118a6dc"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3db3a610-72d9-429b-bb45-12279789032f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""50a2faf3-302a-47fe-aefd-2c3b980be0cf"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bb5ddcdf-0d8a-4765-a84a-db998a2e583e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // User
        m_User = asset.FindActionMap("User", throwIfNotFound: true);
        m_User_Movement = m_User.FindAction("Movement", throwIfNotFound: true);
        m_User_Shoot = m_User.FindAction("Shoot", throwIfNotFound: true);
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

    // User
    private readonly InputActionMap m_User;
    private IUserActions m_UserActionsCallbackInterface;
    private readonly InputAction m_User_Movement;
    private readonly InputAction m_User_Shoot;
    public struct UserActions
    {
        private @InputScheme m_Wrapper;
        public UserActions(@InputScheme wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_User_Movement;
        public InputAction @Shoot => m_Wrapper.m_User_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_User; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UserActions set) { return set.Get(); }
        public void SetCallbacks(IUserActions instance)
        {
            if (m_Wrapper.m_UserActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_UserActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_UserActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_UserActionsCallbackInterface.OnMovement;
                @Shoot.started -= m_Wrapper.m_UserActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_UserActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_UserActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_UserActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public UserActions @User => new UserActions(this);
    public interface IUserActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
}
