using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private GameObject enemy;
    [SerializeField] private Rigidbody2D rb;
  


     void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        
    }




    public void TakeDamage(float amount)
    {
        health -= amount;

        if(health <= 0)
        {
            
            
        }
        
    }

    
}
