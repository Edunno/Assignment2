using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionPoint : MonoBehaviour
{
    public GameObject plane;
    public AudioSource s;
    private bool addFlag = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        s.Play();
        print("works");
        this.GetComponent<MeshRenderer>().enabled = false;
        Destroy(this,100);
        if(addFlag){
            GameObject.Find("Canvas").GetComponent<PointCount>().addPoints();
            addFlag = false;
        }
    }
}
