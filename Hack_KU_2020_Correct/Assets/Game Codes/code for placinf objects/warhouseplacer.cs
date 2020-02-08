using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warhouseplacer : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

  }

  public GameObject Spawnthings;

  // Update is called once per frame
  void Update()
  {
      //has the mouse been click
      if (Input.GetMouseButtonDown(0))
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
  }
}
