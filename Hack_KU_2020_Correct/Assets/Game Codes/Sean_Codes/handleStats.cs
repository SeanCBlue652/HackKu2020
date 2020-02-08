using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sean.CharacterStats;

public class handleStats : MonoBehaviour
{
   public PlayerStat Funds;
   public PlayerStat Power;
   public PlayerStat Population;
   public PlayerStat InPerMin;

   public GameObject FundStat;
   public GameObject PowerStat;
   public GameObject PopuStat;
   public GameObject IPMStat;
   
    void Start()
    {
        writeUpdatedText(Funds, FundStat, "Funds: ");
        writeUpdatedText(Power, PowerStat, "Power: ");
        writeUpdatedText(Population, PopuStat, "Population: ");
        writeUpdatedText(InPerMin, IPMStat, "Income Per Minute: ");
    }

    private void writeUpdatedText(PlayerStat _stat, GameObject _object, string _text) {
        _object.GetComponent<UpdateStatText>().updateText(_text+_stat.Value);
    }

}
