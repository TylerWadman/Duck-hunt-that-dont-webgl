using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private Rigidbody rigBod;
    Vector3 lastVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rigBod = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        lastVelocity = rigBod.velocity;
    }

    private void OnCollisionEnter(Collision coll)
    {
      
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, coll.contacts[0].normal);

        rigBod.velocity = direction * Mathf.Max(speed, 0f);
        transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
    }
}
