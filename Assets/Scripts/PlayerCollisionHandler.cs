using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Alien"))
        {
            Debug.Log("Collision with Alien detected!");
            TriggerGameOver();
        }
    }

    private void TriggerGameOver()
    {
        SceneManager.LoadScene("GameOver");
}
}