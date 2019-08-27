using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIRotator : MonoBehaviour
{
    private bool Move = true;
    private float timer;
    private float angle;
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(1f,5f);
        StartCoroutine(MyCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        if(Move){
            this.transform.Rotate(new Vector3 (0,1,0),angle);
        }
    }
    IEnumerator MyCoroutine(){
        while(true){
            timer = Random.Range(1,5);
            yield return new WaitForSeconds(timer);
            Move = !Move;
            angle = Random.Range(-1,1);
        }
    }
}
