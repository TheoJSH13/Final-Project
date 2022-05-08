using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class infowhalecontroller : MonoBehaviour


{
    private GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.FindGameObjectWithTag("canvas2");

        canvas.GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("info7").GetComponent<Text>().text = "Fact #5";
            canvas.GetComponent<Canvas>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("info7").GetComponent<Text>().text = "";
            canvas.GetComponent<Canvas>().enabled = false;
        }
    }
}
