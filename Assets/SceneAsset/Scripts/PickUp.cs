using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    public GameObject openText;
    public GameObject taskText;
    public string Task;
    public AudioSource keyPickUpSound;

    void Start()
    {

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
                keyPickUpSound.time = 0.2f;
                keyPickUpSound.Play();
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