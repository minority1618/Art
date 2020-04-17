using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour{
    public GameObject label = null;
    void Start(){
    }
    void Update(){
        Text str = label.GetComponent<Text>();
        str.text = "00000";
    }
}
