using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class nextScene : MonoBehaviour
{
    public string SceneToLoad;

    void onTriggerEnter()
    {

        {
            SceneManager.LoadScene("HappyTrainCar");
            Debug.Log("work");
        }
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
