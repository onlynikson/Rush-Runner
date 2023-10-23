using UnityEngine;


public class Shooting : MonoBehaviour
{
    [SerializeField] private Transform shooting;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private AudioSource shoot;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, shooting.position, transform.rotation);
            Debug.Log("shooting well");
            shoot.Play();

        }
    }
}
