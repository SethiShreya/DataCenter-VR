using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyMovement : MonoBehaviour
{
    public Transform head;
    private float feet = 0;

    public void OnValueChange(float newVal)
    {
        feet = newVal;
    }

    void Update()
    {
        transform.position = new Vector3(head.position.x, feet, head.position.z);
    }
}
