using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLight : MonoBehaviour
{
    public Renderer Light;
    public float minTime=1;
    public float maxTime=5;
    public float timer;
    private bool isActive = true;
    public float beepTime = 0.1f;
    private Color color;

    public AudioSource AS;
    public AudioClip AC;

    void Start()
    {
        timer = Random.Range(minTime, maxTime);
        color = Light.material.color;
    }

    void Update()
    {
        flickerLight();
    }

    private void flickerLight()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer < 0)
        {
            StartCoroutine(TurnLight());
            isActive = !isActive;
            timer = Random.Range(minTime, maxTime);
            AS.PlayOneShot(AC);
        }
    }

    IEnumerator TurnLight()
    {
        Light.material.color = Color.white;
        Light.material.SetColor("_EmissionColor", Color.white);

        yield return new WaitForSeconds(beepTime);
        Light.material.color = Color.red;
        Light.material.SetColor("_EmissionColor", color);
    }
}
