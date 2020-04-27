using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    

public class ShipController : MonoBehaviour
{
    public float speed;
    public float Min, Max, Mini, Maxi;
    public GameObject Missile;
    public Transform MissileSpawn;
    public Rigidbody rigidbody;
    public float fireRate;
    private float nextFire;


    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(Missile, MissileSpawn.position, MissileSpawn.rotation);
        }
    }

    
        

    void FixedUpdate ()

    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        rigidbody.velocity = movement * speed;
        rigidbody.position = new Vector3(Mathf.Clamp(rigidbody.position.x, Min, Max), Mathf.Clamp(rigidbody.position.y, Mini, Maxi), -1.02f);
        
    }
}
