using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorway : MonoBehaviour
{

    public GameObject objectToDisable;
    public GameObject objectToEnable;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objectToDisable.SetActive(false);
            objectToEnable.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        objectToDisable.SetActive(true);
        objectToEnable.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
