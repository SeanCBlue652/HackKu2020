using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sean.CharacterStats;

public class handleStats : MonoBehaviour
{
   public PlayerStat Funds;
   
   public GameObject FundStat;
    void Start()
    {
        FundStat.GetComponent<UpdateStatText>().updateText("Funds: "+Funds.Value);
    }

}
