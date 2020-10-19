using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    
    public float speed = 3;
    private Transform playerTransform;
    private int accelerationTime = 3;
    public CameraShake cameraShake;
    bool IsShaking;

   



   
    void Start()
    {
        
        playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {


        Vector3 movementX = Vector3.right * Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        transform.Translate(movementX);

        Vector3 movementY = Vector3.up * Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        transform.Translate(movementY);












    }




        //mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //direction = (mousePosition - transform.position).normalized;
        //rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);
    
}
