using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
     private GameObject enemy;
    private Rigidbody2D rb;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health enemy = collision.GetComponent<Health>();

        if(enemy != null)
        {
            enemy.TakeDamage(1);
            
        }
        
        
    }
}
