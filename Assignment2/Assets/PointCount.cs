using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class PointCount : MonoBehaviour
{
    private int points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponentInChildren<Text>().text = points.ToString();
    }

    public void addPoints(){
        points++;
        GameObject.Find("Text").transform.DOShakePosition(2f,5,10,70,false,true);
    }
}
