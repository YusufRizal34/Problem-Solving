using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Player")]
    public Transform player;

    [Header("Object Controller")]
    public GameObject square;
    
    public int squareTotal;
    private int squareCounter;

    public List<GameObject> squareObject = new List<GameObject>();

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
            EarlySpawn(squareObject, square);            
        }
    }
    
    private void Update() {
        if(score < 0){
            score = 0;
        }
        UpdateScore();
    }

    public void CreateObject(List<GameObject> listObject, GameObject objects){
        GameObject obj = Instantiate(objects);
        obj.SetActive(false);
        listObject.Add(obj);
    }

    public void EarlySpawn(List<GameObject> listObject, GameObject objects){
        float distance = Vector2.Distance(player.position, GetPosition());

        if(distance > 1.5f){
            GameObject obj = Instantiate(objects, GetPosition(), transform.rotation.normalized);
            listObject.Add(obj);
            squareCounter++;
        }
    }

    public Vector3 GetPosition(){
        float yPosition = Random.Range(-yArea, yArea);
        float xPosition = Random.Range(-xArea, xArea);

        return new Vector3(xPosition, yPosition, 0f);
    }

    public GameObject GetPooledObject(List<GameObject> listObject){
        for(int i = 0; i < listObject.Count; i++){
            if(!listObject[i].activeInHierarchy){
                return listObject[i];
            }
        }
        return null;
    }

    private void UpdateScore(){
        if(scoreText != null){
            scoreText.text = "Score: " + score;
        }
    }
}
