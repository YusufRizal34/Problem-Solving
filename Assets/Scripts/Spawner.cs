using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Player")]
    public Transform player;

    [Header("Square Object")]
    public GameObject square;
    public int squareTotal;
    private int squareCounter = 0;

    [Header("Area")]
    public float xArea = 2;
    public float yArea = 2;
    
    void Start()
    {
        while(squareCounter < squareTotal){
            SpawnSquare();
        }
    }

    public void SpawnSquare(){
        float yPosition = Random.Range(-yArea, yArea);
        float xPosition = Random.Range(-xArea, xArea);
        float distance = Vector2.Distance(player.position, new Vector2(xPosition, yPosition));

        if(distance > 1){
            Instantiate(square, new Vector3(xPosition, yPosition, 0f), transform.rotation.normalized);
            squareCounter++;
        }
    }


}
