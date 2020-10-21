using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    bool IsShaking = false;
    [SerializeField]
    public float m_Stamina = 3;
    [SerializeField]
    private float m_Cooldown = 2;
    [SerializeField]
    private float m_CurrentCooldown;

    public StaminaBar staminaBar;

   


    private void Start()
    {
        
        m_CurrentCooldown = m_Cooldown;
    }
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
        if (Input.GetKey(KeyCode.LeftShift) && (m_Stamina >= 0) && (m_CurrentCooldown >= m_Cooldown))
        {
           
            Dash();
        }
        else
        {
            IsShaking = false;
            if (m_Stamina < 3)
            {

                m_Stamina += 0.1f * Time.deltaTime;

            }
        }
        staminaBar.SetStamina(m_Stamina);

        if (IsShaking)
        {
            Shake(0.4f);
            Time.timeScale = 5;
        }
        else
        {
            Time.timeScale = 1;

            
        }
        if(m_Stamina <= 0)
        {
            m_CurrentCooldown = 0;
           
            
        }
        if (m_CurrentCooldown < m_Cooldown)
        {
            m_CurrentCooldown += 1f * Time.deltaTime;
        }



    }
    void Dash()
    {
        IsShaking = true;
        m_Stamina -= 0.1f * Time.deltaTime;
        staminaBar.SetStamina(m_Stamina);

    }

    
}
     
    
    

