using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class ShootScript : MonoBehaviour
{
    public GameObject bullet;

    private ShootMovement shootMov;
    [SerializeField]
    private Transform shooter;
    
    
    private float currentTimeBeforeEnemyShoot = 1.5f;
    private float timeBeforeEnemyShoot = 2f;



    public LayerMask mask;

    //angles possibles pour shoots.

    float angle = -15f;
    float angle1 = 15f;
    float angle2 = -7.5f;
    float angle3 = 7.5f;
    float angle4 = 10f;
    float angle5 = -10f;
    float angle6 = 5f;
    float angle7 = -5f;


    

    private void Awake()
    {
        shootMov = FindObjectOfType<ShootMovement>();



    }
    void Update()
    {

        Shoot();

        foreach (Collider2D colision in Physics2D.OverlapCircleAll(transform.position, 0.02f, mask))
        {

            if (colision.CompareTag("Bullet"))
            {
                colision.tag = "Untagged";
                MakeDamage();
                Destroy(colision.gameObject);
            }


        }

    }

      
    
        void MakeDamage()
        {
          GetComponent<HealthComponent>().TakeDamage(20);
        }
    
    
    
    
    
    
        void Shoot()
        {

            if (gameObject.tag == "Player")
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    GameObject bullet1 = Instantiate(bullet, shooter.position, Quaternion.identity);
                    bullet1.GetComponent<ShootMovement>().SetDir(Vector3.up);
                    bullet1.layer = gameObject.layer;
                }
                else if (Input.GetButtonDown("Fire2"))
                {
                    //for (int i = 0; i < 5; i++)
                    //{
                    //    GameObject go = Instantiate(tamere, Position, angle) as GameObject;
                    //    goList.Add(go);
                    //    go.GetComponent<ShootMovement>().SetDir(new Vector3());
                    //}
                    GameObject bullet1 = Instantiate(bullet, shooter.position, Quaternion.identity);
                    GameObject bullet2 = Instantiate(bullet, shooter.position, Quaternion.identity);
                    GameObject bullet3 = Instantiate(bullet, shooter.position, Quaternion.identity);
                    GameObject bullet4 = Instantiate(bullet, shooter.position, Quaternion.identity);
                    GameObject bullet5 = Instantiate(bullet, shooter.position, Quaternion.identity);

                    bullet1.layer = gameObject.layer;
                    bullet2.layer = gameObject.layer;
                    bullet3.layer = gameObject.layer;
                    bullet4.layer = gameObject.layer;
                    bullet5.layer = gameObject.layer;

                    bullet1.GetComponent<ShootMovement>().SetDir(new Vector3(Mathf.Sin(Mathf.Deg2Rad * angle4), Mathf.Cos(Mathf.Deg2Rad * angle4), 0));
                    bullet2.GetComponent<ShootMovement>().SetDir(new Vector3(Mathf.Sin(Mathf.Deg2Rad * angle5), Mathf.Cos(Mathf.Deg2Rad * angle5), 0));
                    bullet3.GetComponent<ShootMovement>().SetDir(new Vector3(Mathf.Sin(Mathf.Deg2Rad * angle6), Mathf.Cos(Mathf.Deg2Rad * angle6), 0));
                    bullet4.GetComponent<ShootMovement>().SetDir(new Vector3(Mathf.Sin(Mathf.Deg2Rad * angle7), Mathf.Cos(Mathf.Deg2Rad * angle7), 0));
                    bullet5.GetComponent<ShootMovement>().SetDir(Vector3.up);
                }
            }

        if (gameObject.tag == "Enemy")
        {
            if (currentTimeBeforeEnemyShoot < timeBeforeEnemyShoot)
            {
                currentTimeBeforeEnemyShoot += Time.deltaTime;
                Debug.Log("Ok");
            }
            else
            {
                Debug.Log("Shoot");
                GameObject bullet1 = Instantiate(bullet, shooter.position, Quaternion.identity);
                bullet1.layer = gameObject.layer;
                bullet1.GetComponent<ShootMovement>().SetDir(Vector3.down);
                currentTimeBeforeEnemyShoot = 0;

            }

        }


        if (gameObject.tag == "Enemy1")
        {
            if (currentTimeBeforeEnemyShoot < timeBeforeEnemyShoot)
            {
                currentTimeBeforeEnemyShoot += Time.deltaTime;
                Debug.Log("Ok");
            }
            else
            {
                Debug.Log("Shoot");
                GameObject bullet1 = Instantiate(bullet, shooter.position, Quaternion.identity);
                GameObject bullet2 = Instantiate(bullet, shooter.position, Quaternion.identity);

                bullet1.layer = gameObject.layer;
                bullet2.layer = gameObject.layer;
               
                bullet1.GetComponent<ShootMovement>().SetDir(new Vector3(Mathf.Sin(Mathf.Deg2Rad * angle2), -Mathf.Cos(Mathf.Deg2Rad * angle2), 0));
                bullet2.GetComponent<ShootMovement>().SetDir(new Vector3(Mathf.Sin(Mathf.Deg2Rad * angle3), -Mathf.Cos(Mathf.Deg2Rad * angle3), 0));
                currentTimeBeforeEnemyShoot = 0;

            }
        }

        if (gameObject.tag == "Enemy2")
        {
            if (currentTimeBeforeEnemyShoot < timeBeforeEnemyShoot)
            {
                currentTimeBeforeEnemyShoot += Time.deltaTime;
                Debug.Log("Ok");
            }
            else
            {
                Debug.Log("Shoot");
                GameObject bullet1 = Instantiate(bullet, shooter.position, Quaternion.identity);
                GameObject bullet2 = Instantiate(bullet, shooter.position, Quaternion.identity);
                GameObject bullet3 = Instantiate(bullet, shooter.position, Quaternion.identity);
                GameObject bullet4 = Instantiate(bullet, shooter.position, Quaternion.identity);
                GameObject bullet5 = Instantiate(bullet, shooter.position, Quaternion.identity);

                bullet1.layer = gameObject.layer;
                bullet2.layer = gameObject.layer;
                bullet3.layer = gameObject.layer;
                bullet4.layer = gameObject.layer;
                bullet5.layer = gameObject.layer;

                bullet1.GetComponent<ShootMovement>().SetDir(new Vector3(Mathf.Sin(Mathf.Deg2Rad * angle4), -Mathf.Cos(Mathf.Deg2Rad * angle4), 0));
                bullet2.GetComponent<ShootMovement>().SetDir(new Vector3(Mathf.Sin(Mathf.Deg2Rad * angle5), -Mathf.Cos(Mathf.Deg2Rad * angle5), 0));
                bullet3.GetComponent<ShootMovement>().SetDir(new Vector3(Mathf.Sin(Mathf.Deg2Rad * angle6), -Mathf.Cos(Mathf.Deg2Rad * angle6), 0));
                bullet4.GetComponent<ShootMovement>().SetDir(new Vector3(Mathf.Sin(Mathf.Deg2Rad * angle7), -Mathf.Cos(Mathf.Deg2Rad * angle7), 0));
                bullet5.GetComponent<ShootMovement>().SetDir(Vector3.down);
                currentTimeBeforeEnemyShoot = 0;

            }
        }

    }






  

        
}



  




