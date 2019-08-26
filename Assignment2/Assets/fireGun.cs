using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireGun : MonoBehaviour
{
    public GameObject flare;
    public GameObject bullet;
    public AudioSource ASource;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            
            Vector3 flarePos = this.transform.position+this.transform.right.normalized;
            flarePos.y = flarePos.y-(float)0.2;
            GameObject deployedFlare = (GameObject) Instantiate(flare,flarePos,Quaternion.identity);
            ASource.Play();
            Destroy(deployedFlare,1);
            GameObject tempB = (GameObject) Instantiate(bullet,this.transform.position,Quaternion.identity);
            tempB.GetComponent<Rigidbody>().AddForce(this.transform.right*200);
            Destroy(tempB,10);
        }
    }
}
