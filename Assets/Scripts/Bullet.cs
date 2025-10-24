using UnityEditor.Tilemaps;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 15f;
    public float lifetime = 3f;
    public GameObject FirePoint;
    public PlayerController player;
    
    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void Update()
    {


        float horizontal = Input.GetAxis("Horizontal");

        
        Vector2 flipper = Vector2.right;

        if (horizontal < 0)
            flipper = Vector2.left;
        else if (horizontal > 0)
            flipper = Vector2.right;

        transform.Translate(flipper * speed * Time.deltaTime);






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