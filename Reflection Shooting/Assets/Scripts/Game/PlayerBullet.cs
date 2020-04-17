using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour{
    Rigidbody2D rb;
    int cnt = 0;
    void Start(){
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update(){
        Vector2 pos = transform.position;
        Vector2 min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        Vector2 max = Camera.main.ViewportToWorldPoint(Vector2.one);
        Vector2 vec = rb.velocity;
        if(pos.x < min.x || max.x < pos.x){
            vec.x *= -1;
            cnt++;
        }if(pos.y < min.y || max.y < pos.y){
            vec.y *= -1;
            cnt++;
        }rb.velocity = vec;
        if(cnt > 5) Destroy(this);
    }
    void OnCollisionEnter(Collision e){
        if(e.gameObject.name == "Enemy"){
            int hp = e.gameObject.GetComponent<Enemy>().hp;
            hp--;
            Destroy(this);
        }else if(e.gameObject.name == "EnemyBullet"){
            Destroy(this);
        }
    }
}