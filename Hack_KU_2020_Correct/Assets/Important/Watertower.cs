using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watertower : MonoBehaviour
{
    public GameObject watertower = null;
    public GameObject special = null;
    private bool specialOff = true;

    Ray ray;
    RaycastHit hit;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //print("click");
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
               // print("hit");
                if (hit.collider.gameObject == watertower)
                {
                    //print("yep");
                    if (specialOff == true)
                    {
                        //print("on now");
                        special.gameObject.SetActive(true);
                        specialOff = false;
                    }
                    else
                    {
                        //print("off now");
                        special.gameObject.SetActive(false);
                        specialOff = true;
                    }
                }
            }
        }
    }
}
