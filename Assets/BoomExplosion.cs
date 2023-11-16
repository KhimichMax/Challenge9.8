using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomExplosion : MonoBehaviour
{
    public float radius;
    public float force;
    public bool switchOnExplosion;

    private void Exploed()
    {
        Collider[] arrColliders = Physics.OverlapSphere(transform.position, radius);
        
        for (int i = 0; i < arrColliders.Length; i++)
        {
            Rigidbody rigidbody = arrColliders[i].attachedRigidbody;
            if (rigidbody)
            {
                rigidbody.AddExplosionForce(force, transform.position, radius);
            }
        }
    }

    private void Update()
    {
        if (!switchOnExplosion)
        {
            Exploed();   
        }
    }

    private void Start()
    {
        switchOnExplosion = true;
    }
}
