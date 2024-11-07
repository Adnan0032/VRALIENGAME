using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienGroupCollision : MonoBehaviour
{
    public float speed = 1f;
    public float groupRadius = 2f; 
    public Transform player;
    public GameObject gameOverUI; 
    private Transform target;

    void Start()
    {
        target = Camera.main.transform;
    }

    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        transform.LookAt(target);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Check if aliens are grouped within the radius
            if (IsGroupedWithOtherAliens())
            {
                TriggerGameOver();
            }
        }
    }

    private bool IsGroupedWithOtherAliens()
    {
        Collider[] nearbyAliens = Physics.OverlapSphere(transform.position, groupRadius);

        int alienCount = 0;
        foreach (var collider in nearbyAliens)
        {
            if (collider.gameObject.CompareTag("Alien") && collider.gameObject != this.gameObject)
            {
                alienCount++;
                if (alienCount >= 2) // Adjust this number to decide what "grouped" means
                {
                    return true;
                }
            }
        }
        return false;
    }

    private void TriggerGameOver()
    {
        gameOverUI.SetActive(true); // Show the game over UI
        Time.timeScale = 0; // Pause the game
    }
}
