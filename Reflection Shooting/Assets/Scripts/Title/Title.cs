using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour{
    public GameObject TitleCanvas;
    public GameObject HowtoplayCanvas;
    public GameObject RankingCanvas;
    void Start(){
    }
    void Update(){
    }
    public void OnClickStart(){
        SceneManager.LoadScene("Game");
    }
    public void OnClickHowtoplay(){
        TitleCanvas.SetActive(!TitleCanvas.activeInHierarchy);
        HowtoplayCanvas.SetActive(!HowtoplayCanvas.activeInHierarchy);
    }
    public void OnClickRanking(){
        TitleCanvas.SetActive(!TitleCanvas.activeInHierarchy);
        RankingCanvas.SetActive(!RankingCanvas.activeInHierarchy);
    }
}
