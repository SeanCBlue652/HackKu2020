using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPowerInfo : MonoBehaviour
{
    public GameObject powerMenu;
    public GameObject powerDisplay;
    public GameObject closePowerMenu;

    public void OpenPowerMenu()
    {
        powerDisplay.SetActive(false);
        powerMenu.SetActive(true);
        closePowerMenu.SetActive(true);
    }
    public void ClosePowerMenu()
    {
        powerDisplay.SetActive(true);
        powerMenu.SetActive(false);
        closePowerMenu.SetActive(false);
    }
}
