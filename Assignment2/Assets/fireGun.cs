using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireGun : MonoBehaviour
{
    public GameObject flare;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            Vector3 flarePos = this.transform.position+this.transform.right.normalized;
            Instantiate(flare,flarePos,Quaternion.identity);
        }
    }
}
