using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Invoke("Restart", 1.5f);
            
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
