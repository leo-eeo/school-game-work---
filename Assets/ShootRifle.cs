using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEngine;

public class ShootRifle : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletSpawn;
    public float bulletForce = 10f;
    public float fireRate = 0.1f;
    

    private float nextFireTime = 0f; 



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButton("Fire1") && Time.time >= nextFireTime)
        {
            
            shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }






    }

    public void shoot()
    {
        
        GameObject bullet2 = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
        Rigidbody bulletRb = bullet2.GetComponent<Rigidbody>();
        bulletRb.AddForce(bulletSpawn.forward * bulletForce, ForceMode.Impulse);
        
        Destroy(bullet2, 2.0f);
        

    }
}
