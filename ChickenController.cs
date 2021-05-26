using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenController : MonoBehaviour
{
    private Rigidbody rigBod;
    private DuckHuntManager gameManager;
    public GameObject laughDog;
    public GameObject shotDuck;
    public float randDirec;
    // Start is called before the first frame update
    void Start()
    {
        rigBod = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("DuckHuntManager").GetComponent<DuckHuntManager>();
        rigBod.AddForce(getRandomDirection(), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 7)
        {
            Instantiate(laughDog, new Vector3(transform.position.x, -5, 95), laughDog.transform.rotation);
            Destroy(gameObject);
        }
        
    }

    private void OnMouseDown()
        {
            if(gameManager.ammo > 0)
            {
                gameManager.UpdateScore(10);
                Instantiate(shotDuck,  new Vector3(transform.position.x, transform.position.y, 105), transform.rotation);
                Destroy(gameObject);
            }
        }

    private Vector3 getRandomDirection()
    {
        randDirec = Random.Range(gameManager.score/100, -(gameManager.score/100));
        if (randDirec < 0)
        {
            transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
        }
        return new Vector3(randDirec, Random.Range(1.0f,2.0f), 0);
    }
    
}

