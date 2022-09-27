using System.Collections.Generic;
using Enums;
using Interfaces;
using UnityEngine;

namespace Behaviour.InputSystems
{
    public class PlayerInputs : MonoBehaviour, IInputProvider
    {
        private const string upButton = "Up";
        private const string downButton = "Down";
        private const string JumpButton = "Jump";
        private const string StabButton = "Stab";
        private const string ThrowButton = "Throw";
        
        private HashSet<InputAction> _requestedActions = new HashSet<InputAction>();

        public float GetAxis(Axis axis)
        {
            return Input.GetAxisRaw(axis.ToUnityAxis());
        }

        public bool GetActionPressed(InputAction action)
        {
            return _requestedActions.Contains(action);
        }

        private void Update()
        {
            CaptureInput();
        }

        private void CaptureInput()
        {
            if (Input.GetButton(ThrowButton))
            {
                _requestedActions.Add(InputAction.Throw);
            }
            
            if (Input.GetButtonDown(upButton))
            {
                _requestedActions.Add(InputAction.Up);
            }
            if (Input.GetButtonUp(upButton))
            {
                _requestedActions.Remove(InputAction.Up);
            }
            
            if (Input.GetButtonDown(downButton))
            {
                _requestedActions.Add(InputAction.Down);
            }
            if (Input.GetButtonUp(downButton))
            {
                _requestedActions.Remove(InputAction.Down);
            }
            
            if (Input.GetButtonDown(JumpButton))
            {
                _requestedActions.Add(InputAction.Jump);
            }
            if (Input.GetButtonUp(JumpButton))
            {
                _requestedActions.Remove(InputAction.Jump);
            }
            
            if (Input.GetButtonDown(StabButton))
            {
                _requestedActions.Add(InputAction.Stab);
            }
            if (Input.GetButtonUp(StabButton))
            {
                _requestedActions.Remove(InputAction.Stab);
            }
            
            if (Input.GetButtonDown(ThrowButton))
            {
                _requestedActions.Add(InputAction.Throw);
            }
            if (Input.GetButtonUp(ThrowButton))
            {
                _requestedActions.Remove(InputAction.Throw);
            }
        }
    }
}