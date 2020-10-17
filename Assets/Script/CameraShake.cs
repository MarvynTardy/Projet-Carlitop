using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    bool IsShaking = false;
   

    public void  Shake( float forceShake)
    {
        {
            Vector3 originalPos = transform.localPosition;

            float elapsed = 0.0f;



            float x = Random.Range(-0.3f, 0.3f) * forceShake;
            float y = Random.Range(-0.3f, 0.3f) * forceShake;

            transform.localPosition = new Vector3(x, y, originalPos.z);
            
            elapsed += Time.deltaTime;
          
        }
    }
    private void Update()
    {
        if (Input.GetKey    (KeyCode.LeftShift))
        {
            Dash();
        }
        else
        {
            IsShaking = false;
        }
        

        if (IsShaking)
        {
            Shake(0.4f);
            Time.timeScale = 5;
        }
        else
        {
            Time.timeScale = 1;

            
        }



    }
    void Dash()
    {
        IsShaking = true;


    }
}
     
    
    

