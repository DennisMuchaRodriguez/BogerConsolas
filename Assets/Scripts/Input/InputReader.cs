using UnityEngine;
using System;
using UnityEngine.InputSystem;
public class InputReader : MonoBehaviour
{
    public static event Action<float> OnInputMovement;
    public void InputMovement(InputAction.CallbackContext context)
    {
        OnInputMovement?.Invoke(context.ReadValue<float>());
    }

}
