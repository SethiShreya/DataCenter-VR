using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class LocationManager : MonoBehaviour
{
    [SerializeField] private Transform eve;
    [SerializeField] private Transform camera;
    [SerializeField] private Animator animator;
    [SerializeField] private float OwaitTime;
    [SerializeField] private Transform welcomeParent;
    [SerializeField] private float CwaitTime;
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip[] clips;

    private Transform eveLoc=null;
    private Transform camLoc=null;
    private int index = 0;
    private Transform parentC;

    private const string eveTag = "eveloc";
    private const string camTag = "cameraloc";

    private void Start()
    {
        transformPositions(welcomeParent);
    }

    public void ChangePos(Transform parent=null)
    {
        parentC = parent;
        StartCoroutine(Close());
        
    }

    IEnumerator Close()
    {
        animator.SetBool("Open", false);
        yield return new WaitForSeconds(CwaitTime);
        transformPositions(parentC);

    }

    public void transformPositions(Transform parent = null)
    {


        if (parent == null)
        {
            return;
        }
        for (int i=0; i<parent.childCount; i++)
        {
            Transform child = parent.GetChild(i);

            if (child.tag == eveTag)
            {
                eveLoc = child.transform;
            }
            else if (child.tag == camTag)
            {
                camLoc = child.transform;
            }
        }


        if (eveLoc != null)
        {
            eve.position = new Vector3(eveLoc.position.x, eve.position.y, eveLoc.position.z);

            StartCoroutine(Speak());
        }

        if (camLoc != null)
        {
            camera.position = new Vector3(camLoc.position.x, camera.position.y, camLoc.position.z); 
        }


        IEnumerator Speak()
        {
            yield return new WaitForSeconds(OwaitTime);
            animator.SetBool("Open", true);
            yield return new WaitForSeconds(.5f);
            source.PlayOneShot(clips[index]);
            index++;
        }
        
        
    }
}
