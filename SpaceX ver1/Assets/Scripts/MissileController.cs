using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileController : MonoBehaviour
{
    public float speed;
    public Rigidbody rigidbody;
    
    void Start()
    {
        rigidbody.velocity = new Vector3(0, speed, 0);
    }
}
