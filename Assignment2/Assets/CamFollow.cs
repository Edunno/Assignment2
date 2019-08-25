using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{   
    public Camera fpsCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* this.transform.localRotation = fpsCam.transform.rotation.normalized;
        Vector3 dVect = fpsCam.transform.forward;
        this.transform.localPosition = dVect;*/
        Vector3 pos = fpsCam.WorldToViewportPoint (transform.position);
         pos.x = Mathf.Clamp01(pos.x);
         pos.y = Mathf.Clamp01(pos.y);
         transform.position = fpsCam.ViewportToWorldPoint(pos);
    }
}
