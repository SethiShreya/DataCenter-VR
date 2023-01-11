using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextSizeManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI infoText;
    [SerializeField]private float multiplier = 1;
    [SerializeField]private float minimumSize = 10;
   
    public void IncreaseFont()
    {
        infoText.fontSize += multiplier;
    }

    public void DecreaseFont()
    {
        if (isValid())
        {
            infoText.fontSize -= multiplier;
        }
        return;
    }

    private bool isValid()
    {
        if (infoText.fontSize < minimumSize)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
