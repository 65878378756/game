using UnityEngine;

public class Bonus : MonoBehaviour
{

    private GameObject gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            gameManager.GetComponent<SpawnJewel>().jewelCount++;
        }else if (collision.gameObject.CompareTag("Collider"))
        {
            Destroy(gameObject);
        }
    }
}
