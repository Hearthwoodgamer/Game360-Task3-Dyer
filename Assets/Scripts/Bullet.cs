using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 15f;
    public float lifetime = 3f;
    public GameObject FirePoint;
    public PlayerController player;
    

    private Rigidbody2D rb;
    


    
    void Start()
    {



        rb = GetComponent<Rigidbody2D>();
        // Destroy bullet after lifetime
        rb.linearVelocity = transform.right * speed;
        Destroy(gameObject, lifetime);


    }

    void Update()
    {


        



    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage();
            }
            Destroy(gameObject);
        }

        if (collision.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}