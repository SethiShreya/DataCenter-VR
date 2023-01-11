using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class MenuButtonDirectBinding : MonoBehaviour
{
    [SerializeField] private InputDeviceCharacteristics InputDeviceCharacteristics;
    [SerializeField] private Transform canvas;
    private InputDevice targetDevice;
    private bool active = false;

    void Start()
    {
        tryGetDevice();
    }

    void tryGetDevice()
    {
        List<InputDevice> inputDevices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics, inputDevices);
        if (inputDevices.Count > 0)
        {
            targetDevice = inputDevices[0];
        }
    }

    

    void Update()
    {
        if (!targetDevice.isValid)
        {
            tryGetDevice();
        }
        
        if (targetDevice.TryGetFeatureValue(CommonUsages.menuButton, out active))
        {
            canvas.gameObject.SetActive(active);
        }
    }



}
