using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR.Interaction.Toolkit;

public class DoubleXRGrabInteractable : XRGrabInteractable
{
    [SerializeField] private Transform _secondAttachTransform;
    


    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        if (interactorsSelecting.Count == 1)
        {
        base.ProcessInteractable(updatePhase);
            //transform.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else if (interactorsSelecting.Count == 2 &&
            updatePhase==XRInteractionUpdateOrder.UpdatePhase.Dynamic)
        {
            //transform.GetComponent<MeshRenderer>().material.color = Color.blue;

            TwoHandGrab();
        }
    }

    protected override void Awake()
    {
        base.Awake();
        selectMode = InteractableSelectMode.Multiple;
    }


    void TwoHandGrab()
    {
        Transform _firstAttachTransform = GetAttachTransform(null);
        Transform firstHand = interactorsSelecting[0].transform;
        Transform secondHand = interactorsSelecting[1].transform;

        float initialDistance = Vector3.Distance(_firstAttachTransform.position, _secondAttachTransform.position);
        Vector3 initialScale = transform.localScale;

        float currentDistance = Vector3.Distance(firstHand.position, secondHand.position);
        var factor = currentDistance / initialDistance;
        transform.localScale = initialScale * factor;

    }
}
