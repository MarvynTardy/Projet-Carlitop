using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnnemy : MonoBehaviour
{
    public GameObject ennemy1;
    public GameObject ennemy2;
    public GameObject ennemy3;
    int whoSpawn;

    public float spawnRate;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", spawnRate);
        InvokeRepeating("IncreaseSpawnRate", 0f, 30f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawn()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0.1f, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(0.9f, 1));

        whoSpawn = Random.Range(1, 4);
        switch (whoSpawn)
        { 
            case 1:
                GameObject ennemy =  (GameObject)Instantiate(ennemy1);
                ennemy.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
            break;
            case 2:
                GameObject enemy1 = (GameObject)Instantiate(ennemy2);
                enemy1.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
            break;
            case 3:
                GameObject enemy2 = (GameObject)Instantiate(ennemy3);
                enemy2.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
            break;

            default:
            break;
        }



            NextEnnemySpawn();
    }

    void NextEnnemySpawn()
    {
        float otherSpawn;

        if(spawnRate > 1f)
        {
            otherSpawn = Random.Range(1f, spawnRate);
        }
        else
        {
            otherSpawn = 1f;
        }
        Invoke("Spawn", otherSpawn);
    }

    void IncreaseSpawnRate()
    {
       if (spawnRate > 1f)
        {
            spawnRate--;
        }
       if (spawnRate == 1)
        {
            CancelInvoke("IncreaseSpawnRate");
        }
    }
}
