using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayArea : MonoBehaviour
{
    public Camera camera;
    public float offsetLimitZone = 1;
    float offsetLimitZone2 = 2;
    float offsetLimitZone3 = 2.5f;

    private void Update()
    {
        if (transform.position.x < -camera.orthographicSize* 5/4 + offsetLimitZone)
        {
            transform.position = new Vector3(-camera.orthographicSize* 5/4 + offsetLimitZone, transform.position.y, transform.position.z);
        }

        if (transform.position.x > camera.orthographicSize * 5 / 4 - offsetLimitZone)
        {
            transform.position = new Vector3(camera.orthographicSize * 5 / 4 - offsetLimitZone, transform.position.y, transform.position.z);
        }

        if (transform.position.y < -camera.orthographicSize * 5 / 4 + offsetLimitZone3)
        {
            transform.position = new Vector3(transform.position.x, -camera.orthographicSize * 5 / 4 + offsetLimitZone3, transform.position.z);
        }

        if (transform.position.y > camera.orthographicSize * 5 / 4 - offsetLimitZone2)
        {
            transform.position = new Vector3(transform.position.x, camera.orthographicSize * 5 / 4 - offsetLimitZone2 , transform.position.z);
        }

    }

}
