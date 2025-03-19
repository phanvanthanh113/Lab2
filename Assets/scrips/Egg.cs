using UnityEngine;

public class Egg : MonoBehaviour
{
    public int scoreValue = 10; // Giá trị điểm khi nhặt trứng

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Farmer"))
        {
            GameManager gameManager = FindFirstObjectByType<GameManager>();
            if (gameManager != null)
            {
                gameManager.AddScore(scoreValue);
                Debug.Log("Farmer nhặt trứng! +10 điểm");
            }
            Destroy(gameObject); // Hủy trứng sau khi nhặt
        }
        {
            Destroy(gameObject, 3f);
        }
        
    }
}