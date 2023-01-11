using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuButtonIndirectBinding : MonoBehaviour
{
    [SerializeField] private InputActionReference menuInputActionReference;
    [SerializeField] private Transform canvas;
    private bool active = false;
    private void OnEnable()
    {
        menuInputActionReference.action.started += MenuPressed;
    }

    private void OnDisable()
    {
        menuInputActionReference.action.started -= MenuPressed;

    }

    private void MenuPressed(InputAction.CallbackContext context)
    {
        canvas.gameObject.SetActive(!active);
    }
}
