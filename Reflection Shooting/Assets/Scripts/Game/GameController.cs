using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour{
    public GameObject[] stage = new GameObject[5];
    public GameObject Player;
    public GameObject Enemy;
    int num = 0;
    int score = 0;
    void Start(){
    }
    void Update(){
        int PlayerHp = Player.GetComponent<Player>().hp;
        int EnemyHp = Enemy.GetComponent<Enemy>().hp;
        if(PlayerHp < 0 || EnemyHp < 0){
            score += PlayerHp - EnemyHp;
            stage[num].SetActive(false);
            PlayerHp = 100;
            EnemyHp = 100;
            num++;
            if(num == 5){
                SceneManager.LoadScene("Result");
            }
            stage[num].SetActive(true);
        }
    }
}
