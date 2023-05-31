using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public Animator door;
    public GameObject openText;    
    public GameObject KeyOfTheDoor;
    public GameObject lockedText;
    public bool LastDoor;
    //public GameObject mySelf;


    public AudioSource doorSound;


    public bool inReach;




    void Start()
    {
        inReach = false;
        door.SetBool("Closed", false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            if (KeyOfTheDoor.activeSelf == false)
            {
                inReach = true;
                openText.SetActive(true);
            }
            else
            {
                lockedText.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            openText.SetActive(false);
            lockedText.SetActive(false);
        }
    }





    void Update()
    {

        if (inReach && Input.GetButtonDown("Interact") && door.GetBool("Open")==false)
        {
            DoorOpens();
        }

        else
        {
            DoorCloses();
        }

    }


    void DoorOpens ()
    {
        //Debug.Log("It Opens");
        door.SetBool("Open", true);
        door.SetBool("Closed", false);
        doorSound.Play();
        if (LastDoor)
        {
            gameObject.GetComponent<OutroScript>().enabled = true;
        }
        //Debug.Log(door.GetBool("Open"));

    }

    void DoorCloses()
    {
        //Debug.Log("It Closes");
        door.SetBool("Open", false);
        door.SetBool("Closed", true);
    }


}
