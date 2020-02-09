using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.ObjectModel;
using Sean.CharacterStats;

public class PowerMenuStatHandler : MonoBehaviour
{
    public GameObject PowerStatHandler;
    private handleStats Camden;

    private ReadOnlyCollection<StatModifier> _mods;

    // Start is called before the first frame update
    void Start()
    {
        //PowerStatHandler = GameObject.Find("StatsHandler");
        Camden = PowerStatHandler.GetComponent<handleStats>();
        _mods = Camden.getStatModifiers("Power");
    }


}
