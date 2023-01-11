using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppManager : MonoBehaviour
{
    public void TrainingScene()
    {
        SceneManager.LoadScene(0);
    }
    
    public void DetailScene()
    {
        SceneManager.LoadScene(1);
    }

    public void InteractionScene()
    {
        SceneManager.LoadScene(2);
    }
}
