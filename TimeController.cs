using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public List<GameObject> times;
    public int timeVar;
    public GameObject rain;
    public GameObject fireflies;
    // Start is called before the first frame update
    void Start()
    {
        rain.active = false;
        fireflies.active = false;
        timeVar = (int)Random.Range(0,4);
        times[0].active = false;
        times[1].active = false;
        times[2].active = false;
        times[3].active = false;
        times[timeVar].active = true;

        if((timeVar == 2 && (int)Random.Range(0,4) == 2) || timeVar == 3)
        {
            rain.active = true;
        }
        else if(timeVar == 2 && (int)Random.Range(0,5) == 4)
        {
            fireflies.active = true;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
