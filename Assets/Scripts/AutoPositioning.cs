using UnityEngine;
using UnityEngine.Rendering;

public class AutoPositioning : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        collision.gameObject.transform.localPosition = transform.localPosition;
        collision.gameObject.transform.localScale = transform.localScale;
        collision.gameObject.transform.localRotation = transform.localRotation;
    }

}
