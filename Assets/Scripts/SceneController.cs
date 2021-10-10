using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void GoToScene(int scene){
        if(scene == 0){
            SceneManager.LoadScene(0);
        }
        else if(scene == 1){
            SceneManager.LoadScene(1);
        }
        else if(scene == 2){
            SceneManager.LoadScene(2);
        }
        else if(scene == 3){
            SceneManager.LoadScene(3);
        }
        else if(scene == 4){
            SceneManager.LoadScene(4);
        }
        else if(scene == 5){
            SceneManager.LoadScene(5);
        }
        else if(scene == 6){
            SceneManager.LoadScene(6);
        }
        else if(scene == 7){
            SceneManager.LoadScene(7);
        }
        else if(scene == 8){
            SceneManager.LoadScene(8);
        }
        else if(scene == 9){
            SceneManager.LoadScene(9);
        }
    }
}
