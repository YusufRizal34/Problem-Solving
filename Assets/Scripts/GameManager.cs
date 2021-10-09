using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public static int score;

    private void Awake() {
        score = 0;
    }
    
    private void Update() {
        UpdateScore();
    }

    private void UpdateScore(){
        scoreText.text = "Score: " + score;
    }
}
