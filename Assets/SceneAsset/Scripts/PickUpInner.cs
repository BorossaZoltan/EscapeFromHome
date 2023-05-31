using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpInner : MonoBehaviour
{
    public Animator door;
    public GameObject openText;
    public bool InReach;
    public GameObject taskText;
    public string Task;
    public AudioSource KeySound;

    void Start()
    {
        //gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    private void OnTriggerStay(Collider other)
    {

        if ((other.gameObject.tag == "Player" || other.gameObject.tag == "Reach"))
        {
            Debug.Log("NYITVA");

            openText.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                taskText.GetComponent<Text>().text = Task;
                gameObject.SetActive(false);
                openText.SetActive(false);
                KeySound.time = 0.2f;
                KeySound.Play();
            }
        }
        else
        {
            Debug.Log("CSUKVA");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Reach")
        {
            openText.SetActive(false);
        }
    }
    /*
    void Update()
    {
        //Debug.Log("UPDATE");
        //Debug.Log(door.GetBool("Open"));
        if (door.GetBool("Open"))
        {
            Debug.Log("OPEN");
            gameObject.GetComponent<BoxCollider>().enabled = true;
        }
        else
        {
            //Debug.Log("CLOSED");
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }*/

}