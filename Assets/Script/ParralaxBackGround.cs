using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParralaxBackGround : MonoBehaviour
{
    public float speed;
    private void FixedUpdate()
    {
        Vector3 pos = transform.position;
        pos.y += speed * Time.deltaTime;
        transform.position = pos;
    }
}
