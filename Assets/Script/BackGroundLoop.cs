using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundLoop : MonoBehaviour
{
    public int nombreBackGround = 2;
    public float overlapSpace = -2f;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("pouf");
        float hauteurBackG = ((BoxCollider2D)collider).size.y;

        Vector3 pos = collider.transform.position;
        pos.y -= (hauteurBackG * nombreBackGround) - overlapSpace;

        collider.transform.position = pos;
    }
}
