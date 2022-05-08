using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class infobincontroller2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("info2").GetComponent<Text>().text = "Two-thirds of plastic pollution comes from litter left on beaches. In the UK Approximately 5,000 items of plastic have been found per mile of beach!";
            
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("info2").GetComponent<Text>().text = "";
            
        }
    }
}
