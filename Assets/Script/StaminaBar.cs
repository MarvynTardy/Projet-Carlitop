using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{

    public Slider slider;
    public CameraShake cameraShake;

    private void Start()
    {
        slider.value = cameraShake.m_Stamina;
    }

    public void SetStamina(float _CurrentStamina)
    {
        slider.value = cameraShake.m_Stamina;
    }
}
