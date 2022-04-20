using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeatherBullet : MonoBehaviour
{

    public float bulletSpeed = 40f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    public int damage = 1;
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHealth player = collision.GetComponent<PlayerHealth>();
        if(player!= null)
        {
            player.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

}
