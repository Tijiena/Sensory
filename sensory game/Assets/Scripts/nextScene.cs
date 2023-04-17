using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class nextScene : MonoBehaviour
{
    [SerializeField]
    private string nextSceneName;

    void OnTriggerEnter()
    {

        
            SceneManager.LoadScene(nextSceneName);
            Debug.Log("work");
        
    }
}

//    void Start()
//{




//    UiObject.SetActive(false);
//}
//private void OnTriggerEnter(Collider other)
//{
//    if (other.tag == "Player")
//    {
//        UiObject.SetActive(true);
//    }
//}
//void Update()
//{

//}

//    //void OnTriggerExit(Collider other)
//    //{
//    //    UiObject.SetActive(false);

//    //}

//}
