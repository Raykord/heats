//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/GameplayAssets/Features/CharacterMovement/Utils/InputHandler.inputactions
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

namespace HeatsGame.Features.CharacterMovement
{
    public partial class @InputHandler: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputHandler()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputHandler"",
    ""maps"": [
        {
            ""name"": ""MovmentDefault"",
            ""id"": ""6a08f3c5-cb72-4e12-a212-439cfd5ccd2a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""fb089c0a-528b-4f7b-9d39-30b4b697b6b0"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Space"",
                    ""type"": ""Button"",
                    ""id"": ""285915d0-3e52-4805-a8e3-ff03dd7771a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Mouse"",
                    ""type"": ""Value"",
                    ""id"": ""55c7cbd4-1195-4982-81b0-c0cfedf3801e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""25032386-cfcc-4203-a089-f8330a6cb48a"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c55540e2-2efa-4961-9609-d38e8899d165"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultCharacterInput"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""645fa666-78e2-4b0e-9ed9-65afae74839f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultCharacterInput"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""forward"",
                    ""id"": ""dfdb5e02-8a89-4215-86a1-131d49964c33"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultCharacterInput"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""backward"",
                    ""id"": ""ccee0f92-cf80-4aa2-b65c-70b56a6ce8ae"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultCharacterInput"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""49f27564-f1cf-4be1-91dd-8bb7b5ee49f3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultCharacterInput"",
                    ""action"": ""Space"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6c67cf6-5980-45b8-95c4-d44d53539fab"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultCharacterInput"",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""DefaultCharacterInput"",
            ""bindingGroup"": ""DefaultCharacterInput"",
            ""devices"": []
        }
    ]
}");
            // MovmentDefault
            m_MovmentDefault = asset.FindActionMap("MovmentDefault", throwIfNotFound: true);
            m_MovmentDefault_Movement = m_MovmentDefault.FindAction("Movement", throwIfNotFound: true);
            m_MovmentDefault_Space = m_MovmentDefault.FindAction("Space", throwIfNotFound: true);
            m_MovmentDefault_Mouse = m_MovmentDefault.FindAction("Mouse", throwIfNotFound: true);
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

        // MovmentDefault
        private readonly InputActionMap m_MovmentDefault;
        private List<IMovmentDefaultActions> m_MovmentDefaultActionsCallbackInterfaces = new List<IMovmentDefaultActions>();
        private readonly InputAction m_MovmentDefault_Movement;
        private readonly InputAction m_MovmentDefault_Space;
        private readonly InputAction m_MovmentDefault_Mouse;
        public struct MovmentDefaultActions
        {
            private @InputHandler m_Wrapper;
            public MovmentDefaultActions(@InputHandler wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_MovmentDefault_Movement;
            public InputAction @Space => m_Wrapper.m_MovmentDefault_Space;
            public InputAction @Mouse => m_Wrapper.m_MovmentDefault_Mouse;
            public InputActionMap Get() { return m_Wrapper.m_MovmentDefault; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MovmentDefaultActions set) { return set.Get(); }
            public void AddCallbacks(IMovmentDefaultActions instance)
            {
                if (instance == null || m_Wrapper.m_MovmentDefaultActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_MovmentDefaultActionsCallbackInterfaces.Add(instance);
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Space.started += instance.OnSpace;
                @Space.performed += instance.OnSpace;
                @Space.canceled += instance.OnSpace;
                @Mouse.started += instance.OnMouse;
                @Mouse.performed += instance.OnMouse;
                @Mouse.canceled += instance.OnMouse;
            }

            private void UnregisterCallbacks(IMovmentDefaultActions instance)
            {
                @Movement.started -= instance.OnMovement;
                @Movement.performed -= instance.OnMovement;
                @Movement.canceled -= instance.OnMovement;
                @Space.started -= instance.OnSpace;
                @Space.performed -= instance.OnSpace;
                @Space.canceled -= instance.OnSpace;
                @Mouse.started -= instance.OnMouse;
                @Mouse.performed -= instance.OnMouse;
                @Mouse.canceled -= instance.OnMouse;
            }

            public void RemoveCallbacks(IMovmentDefaultActions instance)
            {
                if (m_Wrapper.m_MovmentDefaultActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IMovmentDefaultActions instance)
            {
                foreach (var item in m_Wrapper.m_MovmentDefaultActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_MovmentDefaultActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public MovmentDefaultActions @MovmentDefault => new MovmentDefaultActions(this);
        private int m_DefaultCharacterInputSchemeIndex = -1;
        public InputControlScheme DefaultCharacterInputScheme
        {
            get
            {
                if (m_DefaultCharacterInputSchemeIndex == -1) m_DefaultCharacterInputSchemeIndex = asset.FindControlSchemeIndex("DefaultCharacterInput");
                return asset.controlSchemes[m_DefaultCharacterInputSchemeIndex];
            }
        }
        public interface IMovmentDefaultActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnSpace(InputAction.CallbackContext context);
            void OnMouse(InputAction.CallbackContext context);
        }
    }
}
