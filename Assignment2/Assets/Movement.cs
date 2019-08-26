using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MyCoroutine()
    {
        while(true){
            print("works");
            yield return new WaitForSeconds(0.1f);
            Vector3 newPos = this.gameObject.transform.position;
            newPos.x = newPos.x+Random.Range(5,-5);
            newPos.y = newPos.y+Random.Range(5,-5);
            newPos.z = newPos.z+Random.Range(5,-5);
            transform.position = newPos;
            print("done");
        }
    }
}
