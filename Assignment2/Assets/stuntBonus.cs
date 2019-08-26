using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stuntBonus : MonoBehaviour
{
    private bool flag = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(){
        if(flag){
            print("time added");
            GameObject.Find("Canvas").GetComponent<CountDown>().TimeAdder();
            flag = false;
        }
        StartCoroutine(WaitReset());
    }
    IEnumerator WaitReset(){
        while(true){
            yield return new WaitForSeconds(6f);
            flag = true;
        }
    } 
}
