using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void OnEnable()
    {
        //only specifying the scene name or build index to load scene
        SceneManager.LoadScene("Intro", LoadSceneMode.Single);
    }
}
