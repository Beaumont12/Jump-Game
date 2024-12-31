using UnityEngine;

public class DeathZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            UnityEngine.Debug.Log("Player fell! Restarting the game...");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0); // Reload the current scene
        }
    }
}
