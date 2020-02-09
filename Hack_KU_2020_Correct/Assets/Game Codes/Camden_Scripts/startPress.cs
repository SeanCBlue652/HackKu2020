﻿//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startPress : MonoBehaviour
{
    public GameObject start = null;

    private bool started = (SceneManager.GetActiveScene().name == "Sean_Main");
    //public string GameSceneName;

    Ray ray;
    RaycastHit hit;

    void FixedUpdate()
    {
        if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    print(hit.collider.name);
                    if (hit.collider.gameObject == start)
                    {
                        print("hit");
                        started = true;
                        SceneManager.LoadScene("Sean_Main", LoadSceneMode.Single);
                    }
                }

            }
        }


    }
}
