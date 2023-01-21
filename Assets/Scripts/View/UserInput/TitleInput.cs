using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace View
{
    public class TitleInput : MonoBehaviour
    {
        public Action onStartAction;
        public Action offStartAction;

        public void OnStart(InputAction.CallbackContext context)
        {
            if (context.phase == InputActionPhase.Performed)
            {
                onStartAction();
            }
            else
            {
                offStartAction();
            }
        }
    }
}


