using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    public int seconds;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
         TimeSpan res = TimeSpan.FromSeconds(seconds);
         string fromTimeS = res.ToString("mm':'ss");
        this.GetComponentInChildren<Text>().text = fromTimeS;
        if(seconds == 0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    IEnumerator MyCoroutine(){
        while(true){
            print("works");
            yield return new WaitForSeconds(1f);
            seconds--;
        }
    }
    public void TimeAdder(){
        seconds = seconds+20;
    }
}
