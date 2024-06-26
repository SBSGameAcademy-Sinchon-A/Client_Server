using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlyForTest : MonoBehaviour
{
    PlayerStatus playerStatus;
    UIManager uiManager;
    SaveLoadManager saveLoadManager;

    void Start()
    {
        playerStatus = Singleton.instance.GetComponentInChildren<PlayerStatus>();
        uiManager = Singleton.instance.GetComponentInChildren<UIManager>();
        saveLoadManager = Singleton.instance.GetComponentInChildren<SaveLoadManager>();
    }

    void Update()
    {
        // Scene Management Test
        if (Input.GetKeyDown(KeyCode.F9))
        {
            playerStatus.hp -= 10;
            playerStatus.mp -= 10;
            uiManager.RenewIngameUI();
        }

        else if (Input.GetKeyDown(KeyCode.F10))
        {
            saveLoadManager.Save();
        }
    }
}
