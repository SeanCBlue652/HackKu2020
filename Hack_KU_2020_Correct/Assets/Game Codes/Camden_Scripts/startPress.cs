﻿//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startPress : MonoBehaviour
{
    public GameObject start = null;
    public string GameSceneName;

    Ray ray;
    RaycastHit hit;

    void update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MainMenu"))
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    print(hit.collider.name);
                    if (hit.collider.gameObject == start)
                    {
                        print("hit");
                        SceneManager.LoadScene("Sean_Main", LoadSceneMode.Single);
                    }
                }
            }
        }

    }
}
