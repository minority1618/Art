using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{
    public int hp;
    GameObject Player;
    void Start(){
        Player = GameObject.Find("Player");
    }
    void Update(){
    }
    void dfs(int x, int y){}
}