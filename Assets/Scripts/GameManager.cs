using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Player")]
    public Transform player;

    [Header("Square Object")]
    public GameObject square;
    public int squareTotal;
    public int squareCounter;
    private List<GameObject> poolingObject = new List<GameObject>();

    [Header("Area")]
    public float xArea = 2;
    public float yArea = 2;

    [Header("Score")]
    public Text scoreText;
    public static int score;

    private void Awake() {
        if(Instance == null){
            Instance = this;
        }
    }

    private void Start() {
        score = 0;

        while(squareCounter < squareTotal){
            SpawnSquare();
        }
    }
    
    private void Update() {
        UpdateScore();
    }

    public void SpawnSquare(){
        float distance = Vector2.Distance(GameManager.Instance.player.position, GetPosition());

        if(distance > 1.5f){
            GameObject obj = Instantiate(square, GetPosition(), transform.rotation.normalized);
            poolingObject.Add(obj);
            squareCounter++;
        }
    }

    public Vector3 GetPosition(){
        float yPosition = Random.Range(-yArea, yArea);
        float xPosition = Random.Range(-xArea, xArea);

        return new Vector3(xPosition, yPosition, 0f);
    }

    public GameObject GetPooledObject(){
        for(int i = 0; i < poolingObject.Count; i++){
            if(!poolingObject[i].activeInHierarchy){
                return poolingObject[i];
            }
        }
        return null;
    }

    private void UpdateScore(){
        scoreText.text = "Score: " + score;
    }
}
