using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private AnimationClip eyeOpen;
    [SerializeField] private AnimationClip eyeClose;
    [SerializeField] private AnimationClip handsOpen;
    [SerializeField] private AnimationClip handsClose;
    private Animator animation;

    void Start()
    {
        animation = GetComponent<Animator>();
    }

    public void PlayEyeOpen()
    {
        
    }
}
