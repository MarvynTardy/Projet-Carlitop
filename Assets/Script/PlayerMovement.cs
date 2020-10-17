using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public string axis;
    public float speed = 10;
    private Transform playerTransform;
    private int accelerationTime = 3;
    public CameraShake cameraShake;
    bool IsShaking;
    Vector3 movement;

   



    void Start()
    {
        playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       

        Vector3 movement = Vector3.right * Input.GetAxisRaw(axis) * speed * Time.deltaTime;
        transform.Translate(movement);
        














    }




}
