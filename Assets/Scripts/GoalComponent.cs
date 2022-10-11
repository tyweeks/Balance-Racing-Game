using UnityEngine;

public class GoalComponent : MonoBehaviour
{
    private bool gameWon = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !gameWon)
        {
            gameWon = true;
            Debug.Log("Game Won!");
            var gameManager = FindObjectOfType<EndGame>();
            gameManager.RestartGame();
        }
    }
}
