using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startPress : MonoBehaviour
{
    public GameObject start = null;

    Ray ray;
    RaycastHit hit;

    public void OnMouseDown()
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
        }
    }
}
