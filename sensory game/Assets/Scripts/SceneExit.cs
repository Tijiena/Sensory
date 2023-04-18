using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneExit : MonoBehaviour
{
    public string sceneToLoad;

    void OnTriggerEnter()
    {
        SceneManager.LoadScene("sceneToLoad");
        Debug.Log("working");
    }


}
