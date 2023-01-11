using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractablesManager : MonoBehaviour
{
    public GameObject[] interactables;

    public void DisableAll(Transform currentobject)
    {
        foreach(GameObject interactable in interactables)
        {
            if (ReferenceEquals(interactable, currentobject.gameObject))
            {
                return;
            }
            else
            {
                DoubleXRGrabInteractable grabbable =interactable.GetComponent<DoubleXRGrabInteractable>();
                grabbable.enabled = false;
            }
        }
    }

    public void EnableAll()
    {
        foreach (GameObject interactable in interactables)
        {
            
                DoubleXRGrabInteractable grabbable = interactable.GetComponent<DoubleXRGrabInteractable>();
                grabbable.enabled = true;
            
        }
    }
}
