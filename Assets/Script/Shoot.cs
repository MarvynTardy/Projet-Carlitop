using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    
    private ShootMovement shootMov;
    public GameObject player;
    public GameObject ennemy;

    public Transform spawnPoint;
    public Transform bulletEnnemySpawn;
 

    private void Awake()
    {
       shootMov = FindObjectOfType<ShootMovement>()  ;
        
    }
    void Update()
    {

        PShoot();
    }
    void PShoot()
        { 
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet1 = Instantiate(bullet, spawnPoint.transform.position, Quaternion.identity);

            bullet1.GetComponent<ShootMovement>().SetDir(Vector3.up);

            
        }


                


        }
       
    void TirEnnemy()
    {
        GameObject bullet1 = Instantiate(bullet, spawnPoint.transform.position, Quaternion.identity);

        bullet1.GetComponent<ShootMovement>().SetDir(Vector3.up);

    }
    
}
