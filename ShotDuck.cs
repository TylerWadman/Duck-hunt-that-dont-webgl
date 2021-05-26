using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotDuck : MonoBehaviour
{
    private Rigidbody rigBod;
    public GameObject dog;
    // Start is called before the first frame update
    void Start()
    {
        rigBod = GetComponent<Rigidbody>();
        rigBod.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        rigBod.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(dog, new Vector3((int)transform.position.x, (int)transform.position.y, 95), dog.transform.rotation);
        Debug.Log(other);
        Destroy(gameObject);
    }

    float RandomTorque()
    {
        return Random.Range(-10, 10);
    }
    
}
