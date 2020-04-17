using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    public int hp;
    public GameObject PlayerBullet;
    public GameObject Empty;
    float dr = 0.05f;
    void Start(){
    }
    void Update(){
        Vector2 pos = transform.position;
        Vector2 min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        Vector2 max = Camera.main.ViewportToWorldPoint(Vector2.one);
        if(Input.GetKey(KeyCode.D) && pos.x < max.x){
            pos.x += dr;
        }else if(Input.GetKey(KeyCode.A) && min.x < pos.x){
            pos.x -= dr;
        }else if(Input.GetKey(KeyCode.W) && pos.y < max.y){
            pos.y += dr;
        }else if(Input.GetKey(KeyCode.S) && min.y < pos.y){
            pos.y -= dr;
        }
        transform.position = pos;

        Vector2 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        dir /= dir.magnitude;
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Acos(dir.x));
        if(Input.GetMouseButtonDown(0)){
            GameObject g = Instantiate(PlayerBullet, Empty.transform);
            g.transform.position = transform.position;
            g.gameObject.GetComponent<Rigidbody2D>().velocity = 10 * dir;
        }
    }
}