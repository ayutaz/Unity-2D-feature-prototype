using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _Project
{
    public class UserInput : MonoBehaviour
    {
        private void Update()
        {
            if(Keyboard.current.sKey.wasPressedThisFrame)
            {
                Debug.Log("S key was pressed");
            }
            
            if(Keyboard.current.sKey.wasReleasedThisFrame)
            {
                Debug.Log("S key was released");
            }
            
            if(Mouse.current.leftButton.isPressed)  // isPressed is a property of the Mouse.current.leftButton
            {
                Debug.Log("Left mouse button is pressed");
            }
            
        }
    }
}