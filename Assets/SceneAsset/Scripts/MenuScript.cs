using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public static bool MainMenuAcitive = true;

    public GameObject MainMenuUI;
    public GameObject MajmokUI;
    public GameObject TasksUI;
    public GameObject player;
    public Camera menuCam;

    void Start()
    {
        player.GetComponent<SC_FPSController>().enabled = false;
        MajmokUI.SetActive(false);
        TasksUI.SetActive(false);
    }

    public void Play()
    {
        MainMenuUI.SetActive(false);
        MajmokUI.SetActive(true);
        TasksUI.SetActive(true);
        menuCam.enabled = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1f;
        MainMenuAcitive = false;
        player.GetComponent<SC_FPSController>().enabled = true;
    }
}
