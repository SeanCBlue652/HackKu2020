//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startPress : MonoBehaviour
{
    public GameObject start = null;


    //public string GameSceneName;

    Ray ray;
    RaycastHit hit;

    void FixedUpdate()
    {
        if (!(SceneManager.GetActiveScene().name == "Sean_Main"))
        {
            if (Input.GetMouseButtonDown(0))
            {
<<<<<<< HEAD
                //print(hit.collider.name);
                if (hit.collider.gameObject == start)
=======
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
>>>>>>> c793e2e44ada0fecf737864094fea86c323c5ff7
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
