using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawner Controller")]
    public float cooldown = 3f;
    private float currentCooldown = 0;

    private void Update() {
        GameObject square = GameManager.Instance.GetPooledObject(GameManager.Instance.squareObject);
        // GameObject triangle = GameManager.Instance.GetPooledObject(GameManager.Instance.triangleObject);

        SpawnOnArena(square);
        // SpawnOnArena(triangle);
    }

    private void SpawnOnArena(GameObject objects){
        if(objects != null){
            Vector2 newPosition = GameManager.Instance.GetPosition();
            float distance = Vector2.Distance(GameManager.Instance.player.position, newPosition);

            if(Time.time > currentCooldown){
                if(distance > 1.5f){
                    objects.transform.position = newPosition;
                    objects.SetActive(true);
                    currentCooldown = Time.time + cooldown;
                }
            }
        }
    }

    private void SpawnOutArena(GameObject objects){
        if(objects != null){
            Vector2 newPosition = GameManager.Instance.GetPosition();

            if(Time.time > currentCooldown){
                objects.transform.position = newPosition * 2;
                objects.SetActive(true);
                currentCooldown = Time.time + cooldown;
            }
        }
    }
}

