using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CustomInputAction : MonoBehaviour
{
    public InputActionReference customButton;

    // Start is called before the first frame update
    void Start()
    {
        customButton.action.started += ButtonWasPressed;
        customButton.action.canceled += ButtonWasReleased;
    }

    void ButtonWasPressed(InputAction.CallbackContext context)
    {
        Debug.Log(0);
    }

    void ButtonWasReleased(InputAction.CallbackContext context)
    {
        Debug.Log(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
