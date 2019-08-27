using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfDestructFlare : MonoBehaviour
{
    private bool flag = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(flag){
            Destroy(this,3);
        flag = false;
        }
        
    }
     void OnTriggerEnter(Collider other){
        if(other.tag == "Enemy"){
            Destroy(other.gameObject);
        }
    }
}
