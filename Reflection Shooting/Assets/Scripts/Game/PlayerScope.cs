using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScope : MonoBehaviour{
    void Start(){
    }
    void Update(){
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        Vector2 max = Camera.main.ViewportToWorldPoint(Vector2.one);
        pos.x = Mathf.Clamp(pos.x, min.x, max.x);
        pos.y = Mathf.Clamp(pos.y, min.y, max.y);
        transform.position = pos;
    }
}