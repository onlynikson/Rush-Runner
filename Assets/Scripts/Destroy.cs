using UnityEngine;

public class Destroy : MonoBehaviour
{
    private GameObject  player;
    [SerializeField] private AudioSource explosion;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        else if(collision.tag == "Player")
        {
            Destroy(player.gameObject);
            explosion.Play();
            
        }
    }
}
