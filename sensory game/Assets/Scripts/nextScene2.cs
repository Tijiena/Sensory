using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene2 : MonoBehaviour
{
    [SerializeField]
    private string nextSceneName;
    // Start is called before the first frame update


   void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)){
            SceneManager.LoadScene("tunnel");
        }
           
        
       
    }
}

