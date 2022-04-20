using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{ 
    public Transform target;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float fireRate = 3000f;
    public float shootingPower = 20f;
    private float shootingTime;
    
   
    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if(Time.time > shootingTime)
        {
            if (target != null)
            {
                shootingTime = Time.time + fireRate / 1000; // sets time between shots
                Vector2 myPos = new Vector2(firePoint.position.x, firePoint.position.y); // creates a point at our position
                GameObject projectile = Instantiate(bulletPrefab, myPos, Quaternion.identity); // creates a bullet at our position
                Vector2 direction = (Vector2)target.position - myPos; // creates a point at the players position
                projectile.GetComponent<Rigidbody2D>().velocity = direction * shootingPower;  // fires the bullet towards player position
            }
        }
        
    }
}
