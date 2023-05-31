using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpMonkey : MonoBehaviour
{
    public GameObject openText;
    public Text majomText;
    public static int monkeyCounter;
    public AudioSource MonkeySound;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Reach")
        {
            openText.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                monkeyCounter += 1;
                majomText.text = "Monkeys: " + monkeyCounter + " / 5";
                gameObject.SetActive(false);
                openText.SetActive(false);
                MonkeySound.Play();
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
