using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour {
    public Vector3 explosionpos;
    public float radius = 5.0f;
    public float power = 10.0f;
    public Collider[] coll;
    public GameObject particlePrefab;
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Explode();
        }

        else
        {
            particlePrefab.active = false;
        }

        explosionpos = this.transform.position;
	}

    void Explode()
    {
        particlePrefab.active = true;
        
         coll = Physics.OverlapSphere(explosionpos, radius);
        foreach (var hit in coll)
        {
           Rigidbody rb = hit.GetComponent<Rigidbody>();
            if(rb != null)
            {
                rb.AddExplosionForce(power, explosionpos, radius, 3.0f);
                //particlePrefab.active = false;
            }
        }
    }   
}
