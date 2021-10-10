using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawner Controller")]
    public float cooldown = 3f;
    private float currentCooldown = 0;

    private void Update() {
        GameObject square = GameManager.Instance.GetPooledObject();

        if(square != null){
            Vector2 newPosition = GameManager.Instance.GetPosition();
            float distance = Vector2.Distance(GameManager.Instance.player.position, newPosition);

            if(Time.time > currentCooldown){
                if(distance > 1.5f){
                    square.transform.position = newPosition;
                    // StartCoroutine(Cooldown(square));
                    square.SetActive(true);
                    currentCooldown = Time.time + cooldown;
                }
            }
        }
    }

    private IEnumerator Cooldown(GameObject square){
        yield return new WaitForSeconds(cooldown);
        square.SetActive(true);
    }
}