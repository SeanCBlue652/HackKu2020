using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButtonClickBehaviour : MonoBehaviour
{
    public GameObject ExitConfirmationButton;
    public void openExitMenu() {
        ExitConfirmationButton.SetActive(true);
    }
}
