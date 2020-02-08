using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButtonClickBehaviour : MonoBehaviour
{
    public GameObject ExitConfirmationButton;
    public void openExitMenu() {
        ExitConfirmationButton.SetActive(true);
    }

    public void closeGame() {
        Application.Quit();
    }

    public void cancelExit() {
        ExitConfirmationButton.SetActive(false);
    }
}
