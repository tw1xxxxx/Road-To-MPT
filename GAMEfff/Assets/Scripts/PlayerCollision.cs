using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Threading;
public class PlayerCollision : MonoBehaviour
{
    public PlayerScript Player;
    public static int CrashCheck;

    void OnCollisionExit(Collision collisionInfo){
        if(collisionInfo.collider.tag == "Obstacle"){
            CrashCheck= 1;
            Invoke("Scene", 0.2f);

        }
    }
    public void Scene() => SceneManager.LoadScene(4);
    
}
