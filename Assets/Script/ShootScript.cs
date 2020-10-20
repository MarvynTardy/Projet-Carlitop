using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject bullet;

    private ShootMovement shootMov;
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Transform enemy;
    private float currentTimeBeforeEnemyShoot = 0f;
    private float timeBeforeEnemyShoot = 1.0f;

    public LayerMask mask;




    private void Awake()
    {
        shootMov = FindObjectOfType<ShootMovement>();



    }
    void Update()
    {

        Shoot();

        foreach (Collider2D colision in Physics2D.OverlapCircleAll(transform.position, 0.1f, mask))
        {

            if (colision.CompareTag("Bullet"))
            {

                Destroy(colision.gameObject);
            }


        }
        void Shoot()
        {
            if (gameObject.tag == "Player")
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    GameObject bullet1 = Instantiate(bullet, player.position, Quaternion.identity);
                    bullet.layer = gameObject.layer;

                    bullet1.GetComponent<ShootMovement>().SetDir(Vector3.up);

                }
            }
            else if (gameObject.tag == "Enemy")
            {
                if (currentTimeBeforeEnemyShoot < timeBeforeEnemyShoot)
                {
                    currentTimeBeforeEnemyShoot += Time.deltaTime;
                    Debug.Log("Ok");
                }
                else
                {
                    Debug.Log("Shoot");
                    GameObject bullet1 = Instantiate(bullet, enemy.position, Quaternion.identity);
                    bullet.layer = gameObject.layer;
                    bullet1.GetComponent<ShootMovement>().SetDir(Vector3.down);
                    currentTimeBeforeEnemyShoot = 0;

                }

            }










        }
    }
}


  




