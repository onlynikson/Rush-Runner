using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private AudioSource boost;
    [SerializeField] private TrailRenderer nitro;
     private Vector2 direction;
    

     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

     void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        direction = new Vector2(0,directionY).normalized;

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 15;
            boost.Play();
            nitro.enabled = true;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5;
            boost.Stop();
            nitro.enabled = false;
            
        }
      

        

       
    }

     void FixedUpdate()
    {
        rb.velocity = new Vector2(0, direction.y * speed);
    }
}
