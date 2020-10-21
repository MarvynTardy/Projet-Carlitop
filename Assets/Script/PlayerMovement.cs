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
    public LayerMask mask;






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


        foreach (Collider2D collision in Physics2D.OverlapCircleAll(transform.position, 0.1f, mask))
        {
            if (collision.CompareTag("player"))
            {
                GetComponent<HealthComponent>().TakeDamage(30);
            }
            
          








        }
    }
}




       /* mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (mousePosition - transform.position).normalized;
        rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);*/
    

