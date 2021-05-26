using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DuckHuntManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText; 
    public GameObject duckPrefab;
    public int ammo;
    public bool reload;
    // Start is called before the first frame update
    void Start()
    {
        score = 100;
        StartCoroutine(SpawnDuck());
        ammo = 3;
        reload = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        if(Input.GetMouseButtonDown(0) && ammo > 0)
        {
            ammo--;
        }
        if(ammo < 3 && mousePos.y < 100 && reload)
        {
            ammo++;
            reload = false;
        }
        if(mousePos.y > 100 && !reload)
        {
            reload = true;
        }
        scoreText.text = "Score: " + score +"\nShots: " + ammo;
    }

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score +"\nShots: " + ammo;
    }

    IEnumerator SpawnDuck()
    {
        while(true){
            if(score < 400)
            {
                yield return new WaitForSeconds(5/(score/100.0f));
                Instantiate(duckPrefab, new Vector3(Random.Range(-8,8), transform.position.y, transform.position.z), transform.rotation);
            }
            else
            {
                yield return new WaitForSeconds(1.2f);
                Instantiate(duckPrefab, new Vector3(Random.Range(-8,8), transform.position.y, transform.position.z), transform.rotation);
            }
        }
    }
}
