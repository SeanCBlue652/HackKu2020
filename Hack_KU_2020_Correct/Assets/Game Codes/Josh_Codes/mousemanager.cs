using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousemanager : MonoBehaviour
{
    [SerializeField]
    private GameObject Spawnthings;

    [SerializeField]
    private KeyCode newObjectHotKey = KeyCode.A;

    private GameObject CurrentPlaceableObject;
    private float mousewheelrotation = 10f;
    // Update is called once per frame
    private void Update()
    {
      /*  //has the mouse been click
        if (Input.GetMouseButtonDown(0) && !(Input.GetKey(KeyCode.C)))
        {
          //button clicked
          //is it over somthing

          Camera theCamera = Camera.main;

          Ray ray = theCamera.ScreenPointToRay(Input.mousePosition );
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
        */
        HandleNewObjectHotKey();
        if (CurrentPlaceableObject != null)
        {
          moveObjecttomouse();
          Rotatefrommousewheel();
          ReleaseIfClicked();
        }
    }

    private void HandleNewObjectHotKey()
    {
      if (Input.GetKeyDown(newObjectHotKey))
      {
        if (CurrentPlaceableObject == null)
        {
          CurrentPlaceableObject = Instantiate(Spawnthings);
        }
        else
        {
          Destroy(CurrentPlaceableObject);
        }
      }
    }

    private void moveObjecttomouse()
    {
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      RaycastHit hitInfo;
      if (Physics.Raycast(ray, out hitInfo))
       {
        CurrentPlaceableObject.transform.position = hitInfo.point;
        CurrentPlaceableObject.transform.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
      }
    }

    private void Rotatefrommousewheel()
    {
      Debug.Log(Input.mouseScrollDelta);
      mousewheelrotation += Input.mouseScrollDelta.y;
      CurrentPlaceableObject.transform.Rotate(Vector3.up, mousewheelrotation * 10f);
    }

    private void ReleaseIfClicked()
    {
      if (Input.GetMouseButtonDown(0))
      {
        CurrentPlaceableObject = null;
      }
    }
}
