using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMovement : MonoBehaviour
{
    
    public float speed = 10f;
    Transform bulletTransform;
    bool isMoving;


    Vector3 wantedDir;
    void Start()
    {
        bulletTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving) Shoot(wantedDir);
    }
    public void Shoot(Vector3 shootDirection)
    {

        transform.Translate(shootDirection * Time.deltaTime * speed);
        
    }

    public void SetDir(Vector3 shootDir)
    {
        isMoving = true;
        wantedDir = shootDir;
    }

}
