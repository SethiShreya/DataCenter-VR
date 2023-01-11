using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using UnityEngine.XR.Interaction.Toolkit;

public class RackSpawner : MonoBehaviour
{
    public InputActionReference AButton;
    public InputActionReference XButton;
    public float offset = 1.5f;
    
    public Transform RacktoSpawn;

    private void OnEnable()
    {
        AButton.action.started += Spawn;
        XButton.action.started += Spawn;
    }

    private void OnDisable()
    {
        
        AButton.action.started -= Spawn;
        XButton.action.started -= Spawn;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            var spawned = Instantiate(RacktoSpawn, Vector3.zero, RacktoSpawn.transform.rotation);
            spawned.transform.position = new Vector3(RacktoSpawn.position.x , RacktoSpawn.position.y, RacktoSpawn.position.z+offset);
            spawned.GetComponentInChildren<Canvas>().worldCamera = Camera.main;
        }
    }

    void Spawn(InputAction.CallbackContext context)
    {
        var spawned = Instantiate(RacktoSpawn, new Vector3(RacktoSpawn.position.x, RacktoSpawn.position.y, RacktoSpawn.position.z + offset), RacktoSpawn.rotation);
        spawned.GetComponentInChildren<Canvas>().worldCamera = Camera.main;
    }
    
    

    
}
