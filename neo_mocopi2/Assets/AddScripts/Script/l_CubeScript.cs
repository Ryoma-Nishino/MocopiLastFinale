using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l_CubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag == "Object"){
            GetComponent<Collider>().enabled = false;
            
            GetComponent<Collider>().enabled = true; 
        }
    }

}
