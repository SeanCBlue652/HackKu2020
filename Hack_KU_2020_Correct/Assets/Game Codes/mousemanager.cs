using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousemanager : MonoBehaviour
{
    public GameObject Spawnthings;

    // Update is called once per frame
    void Update()
    {
        //has the mouse been click
        if (Input.GetMouseButtonDown(0) && !(Input.GetKey(KeyCode.C)))
        {
          //button clicked
          //is it over somthing

          Camera theCamra = Camera.main;

          Ray ray = theCamra.ScreenPointToRay(Input.mousePosition );
          RaycastHit hitInfo;

          if (Physics.Raycast(ray, out hitInfo))
          {
            //Debug.Log("yes, hit " + hitInfo.collider.gameObject.name);
            //spawn new object

            Vector3 spawnspot = hitInfo.collider.transform.position + hitInfo.normal;

            Instantiate(Spawnthings,spawnspot, Quaternion.identity);
          }
        }

        if (Input.GetKey(KeyCode.C) && Input.GetMouseButtonDown(0))
        {
          Camera theCamra = Camera.main;
           RaycastHit hit;
           Ray ray = theCamra.ScreenPointToRay(Input.mousePosition );
           if (Physics.Raycast(ray, out hit))
           {
             //Debug.Log("yes, hit " + hit.collider.gameObject.name);
             BoxCollider bc = hit.collider as BoxCollider;
             if (bc != null )
             {
               Destroy(bc.gameObject);
             }
           }
        }
    }
}
