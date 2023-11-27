using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEngine;

public class ShootRifle : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletSpawn;
    public float bulletForce = 10f;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
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
