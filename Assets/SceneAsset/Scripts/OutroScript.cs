using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OutroScript : MonoBehaviour
{

    public GameObject player;
    public GameObject OutroCam;
    public GameObject OutroUI;
    public GameObject HUD;
    public TMP_Text monkey;



    // Start is called before the first frame update
    void Start()
    {
        HUD.SetActive(false);
        monkey.text = "Collected Monkeys: " + PickUpMonkey.monkeyCounter + " / 5";
        player.SetActive(false);
        OutroCam.SetActive(true);
        OutroUI.SetActive(true);
        Debug.Log("OUTRO");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
