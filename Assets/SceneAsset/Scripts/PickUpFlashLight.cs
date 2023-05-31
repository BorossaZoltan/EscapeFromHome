using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpFlashLight : MonoBehaviour
{
    public GameObject? FlashLightOnPlayer;
    public GameObject openText;
    public GameObject taskText;
    public string Task;
    public AudioSource PickupSound;

    void Start()
    {
        FlashLightOnPlayer.SetActive(false);

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Reach")
        {
            openText.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                taskText.GetComponent<Text>().text = Task;
                gameObject.SetActive(false);
                openText.SetActive(false);
                PickupSound.Play();
                PickupSound.SetScheduledEndTime(AudioSettings.dspTime + (0.2f - 0f));
                FlashLightOnPlayer.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Reach")
        {
            openText.SetActive(false);
        }
    }

}