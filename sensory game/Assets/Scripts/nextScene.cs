using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class nextScene : MonoBehaviour
{
    [SerializeField]
    private string nextSceneName;
    public string exitName;

    void OnTriggerEnter()
    {

        PlayerPrefs.SetString("LastExitName", exitName);
            SceneManager.LoadScene(nextSceneName);
            Debug.Log("work");
        
    }
}
