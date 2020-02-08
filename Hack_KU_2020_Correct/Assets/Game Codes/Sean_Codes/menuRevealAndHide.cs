using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuRevealAndHide : MonoBehaviour
{
   public GameObject Menu;
   public GameObject OpenButton;
   public GameObject CloseButton;

   public void openMenu(){
       OpenButton.SetActive(false);
       Menu.SetActive(true);
       CloseButton.SetActive(true);
   }

   public void closeMenu(){
       OpenButton.SetActive(true);
       Menu.SetActive(false);
       CloseButton.SetActive(false);
   }
}
