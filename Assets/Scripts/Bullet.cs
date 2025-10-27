using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 15f;
    public float lifetime = 3f;
    public GameObject FirePoint;
    public PlayerController player;
    public bool flipper = false;

    private Rigidbody2D rb;
    

    void Start()
    {
       

        
        
        Destroy(gameObject, lifetime);
    }

    void Update()
    {

<<<<<<< HEAD
        transform.Translate(Vector2.right * speed * Time.deltaTime);
=======

        //if (Input.GetKeyDown(KeyCode.D))
            //flipper = true;
        //if (Input.GetKeyDown(KeyCode.A))
            //flipper = false;
        
        //if (flipper == true)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        //if (flipper == false)
            //transform.Translate(Vector2.left * speed * Time.deltaTime);


>>>>>>> 25d7b7d6eb9e5ce7ee8cd740968c65c6eb206f2e

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