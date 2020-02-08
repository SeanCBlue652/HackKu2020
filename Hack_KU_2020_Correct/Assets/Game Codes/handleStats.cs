using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sean.CharacterStats;

public class handleStats : MonoBehaviour
{
   public PlayerStat Funds;
   public PlayerStat Power;
   
   public GameObject FundStat;
   public GameObject PowerStat;
    void Start()
    {
        writeUpdatedText(Funds, FundStat, "Funds: ");
        writeUpdatedText(Power, PowerStat, "Power: ");
    }

    private void writeUpdatedText(PlayerStat _stat, GameObject _object, string _text) {
        _object.GetComponent<UpdateStatText>().updateText(_text+_stat.Value);
    }

}
