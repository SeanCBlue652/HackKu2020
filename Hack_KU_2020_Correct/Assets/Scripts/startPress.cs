﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startPress : MonoBehaviour
{
    public GameObject start = null;
    public GameObject exit = null;

    Ray ray;
    RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                print(hit.collider.name);
                if (hit.collider.gameObject == start)
                {
                    print ("hit");
                    SceneManager.LoadScene("OtherSceneName", LoadSceneMode.Single);
                }
                if (hit.collider.gameObject == exit)
                {
                    print("hit2");
                    Application.Quit();
                }
            }
        }
    }
}