using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogWithDuck : MonoBehaviour
{
    private bool hasGoneUp;
    private Rigidbody rigBod;
    // Start is called before the first frame update
    void Start()
    {
        rigBod = GetComponent<Rigidbody>();
        hasGoneUp = false;
        StartCoroutine(Animate());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    IEnumerator Animate()
    {
        rigBod.AddForce(Vector3.up*2, ForceMode.Impulse);
        yield return new WaitForSeconds(1);
        rigBod.AddForce(Vector3.down*2, ForceMode.Impulse);
        yield return new WaitForSeconds(1);
        rigBod.AddForce(Vector3.down*2, ForceMode.Impulse);
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }


}
