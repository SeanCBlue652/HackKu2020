using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MouseOverDetector : MonoBehaviour
{
    public GameObject target = null;
    public GameObject TooltipWindow = null;
    public Text textBox;
    private Vector3 offset = new Vector3(-40, 20, 0);
    private string tipText = "";
    private string objHover = "";
    Ray ray;
    RaycastHit hit;

    // Update is called once per frame
    void FixedUpdate()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject == target)
            {
                TooltipWindow.gameObject.SetActive(true);
                TooltipWindow.transform.position = Input.mousePosition - offset;
            }
            else
            {
                TooltipWindow.gameObject.SetActive(false);
            }
            objHover = hit.collider.gameObject.name;
        }
        updatetext();
    }
    public void updatetext()
    {
        textBox.text = tipText;
    }
    public void objectDetect()
    {
        switch (objHover)
        {
            case "House":
            tipText = "this is house 1";
            break;
            case "House2":
            tipText = "this is house 2";
            break;
        }
    }
}
