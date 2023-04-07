using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject cube;

    void Start()
    {
        UiObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            UiObject.SetActive(true);
        }
    }
    void Update()
    {

    }

    void OnTriggerExit(Collider other)
    {
        UiObject.SetActive(false);

    }

}