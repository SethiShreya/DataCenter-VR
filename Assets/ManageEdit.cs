using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ManageEdit : MonoBehaviour
{
    public void EnableEdit(XRGrabInteractable interactable)
    {
        interactable.gameObject.GetComponent<BoxCollider>().enabled = !interactable.gameObject.GetComponent<BoxCollider>().enabled;
        interactable.enabled= !interactable.enabled;
    }

    public void ShowDataPanel(GameObject DataPanel)
    {
        DataPanel.SetActive(true);
    }
    public void HideDataPanel(GameObject DataPanel)
    {
        DataPanel.SetActive(false);
    }
}
