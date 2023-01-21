using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace View
{
    public class PlayerInput : MonoBehaviour
    {
        public Action<Vector2> OnPlayerMoveAction;
        public Action<Vector2> CancelPlayerMovetAction;

        public void OnPlayerMove(InputAction.CallbackContext context)
        {
            if (context.phase == InputActionPhase.Performed)
            {
                OnPlayerMoveAction(context.ReadValue<Vector2>());
            }
            else if (context.phase == InputActionPhase.Canceled)
            {
                CancelPlayerMovetAction(context.ReadValue<Vector2>());
            }
        }

    }
}


