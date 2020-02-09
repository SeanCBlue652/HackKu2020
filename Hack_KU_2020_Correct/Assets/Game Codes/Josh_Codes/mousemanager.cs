using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sean;

public class mousemanager : MonoBehaviour
{
    void Start()
    {
        /*for (int i = 0; i < Buildingparts.Length; i++)
        {
          GameObject Buildings = Buildingparts[i];
          GameObject buttonGameObject = (GameObject)Instantiate(Buildingparts, this.transform);
          theButton.onClick.AddListener( () => {Spawnthings = Buildings;} );
        }*/
    }

    [SerializeField]
    private GameObject Spawnthings;

    [SerializeField]
    private KeyCode newObjectHotKey = KeyCode.Mouse1;

    private GameObject CurrentPlaceableObject;
    private float mousewheelrotation = 10f;
    //-------------------------------------------------------------------------------
    public GameObject[] Buildingparts;

    private GameObject _spawnthings;

    public void setspawnthing(GameObject inputbulding)
    {
        _spawnthings = inputbulding;
        print(_spawnthings);
    }

    public mousemanager()
    {
        _spawnthings = Spawnthings;
    }

    void Start(){
      _spawnthings = Spawnthings;
    }
    // Update is called once per frame
    private void Update()
    {
        /*    //has the mouse been click
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
    */
        if (Input.GetKey(KeyCode.C) && Input.GetMouseButtonDown(0))
        {
            Camera theCamra = Camera.main;
            RaycastHit hit;
            Ray ray = theCamra.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("yes, hit " + hit.collider.gameObject.name);
                BoxCollider bc = hit.collider as BoxCollider;
                if (bc != null)
                {
                    Destroy(bc.gameObject);
                }
            }
        }

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
            if (CurrentPlaceableObject != null)
            {
                Destroy(CurrentPlaceableObject);
            }
            else
            {
                CurrentPlaceableObject = Instantiate(_spawnthings);
            }
        }
    }

    private void moveObjecttomouse()
    {
        CurrentPlaceableObject.layer = 2;

        Camera theCamera = Camera.main;

        Ray ray = theCamera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {
            /* Vector3 spawnspot = hitInfo.collider.transform.position + hitInfo.normal;

             Instantiate(Spawnthings,spawnspot, Quaternion.identity);
             */
            CurrentPlaceableObject.transform.position = hitInfo.point;
            CurrentPlaceableObject.transform.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
        }
    }

    private void Rotatefrommousewheel()
    {
        //Debug.Log(Input.mouseScrollDelta);
        mousewheelrotation += Input.mouseScrollDelta.y;
        CurrentPlaceableObject.transform.Rotate(Vector3.up, mousewheelrotation * 10f);
    }

    private void ReleaseIfClicked()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CurrentPlaceableObject.layer = 0;
            CurrentPlaceableObject = null;
        }
    }

    private void onCollisionEnter(Collision collision)
    {
        Debug.Log("Collided With " + collision.gameObject.name);

    }
}
