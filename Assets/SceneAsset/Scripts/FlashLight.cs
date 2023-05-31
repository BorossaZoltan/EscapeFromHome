using UnityEngine;
using System.Collections;

public class FlashLight : MonoBehaviour
{
    private Light myLight;
    public AudioSource lightSwitch;

    void Start()
    {
        myLight = GetComponent<Light>();
        myLight.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            myLight.enabled = !myLight.enabled;
            lightSwitch.time = 0.3f;
            lightSwitch.Play();
        }
    }
}