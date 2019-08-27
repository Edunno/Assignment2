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
            float pitchAngle = 90;//Vector3.Angle(new Vector3(1,0,1),Camera.main.transform.eulerAngles.normalized);
            Destroy(deployedFlare,1);
            GameObject tempB = (GameObject) Instantiate(bullet,new Vector3(this.transform.position.x,this.transform.position.y+0.1f,this.transform.position.z),Quaternion.AngleAxis(pitchAngle,Camera.main.transform.right));
            tempB.GetComponent<Rigidbody>().AddForce(this.transform.right*80);
            Destroy(tempB,10);
        }
    }
}
