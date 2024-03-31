using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * 50f, ForceMode2D.Impulse);
        Destroy(gameObject, 3f);
    }
}
