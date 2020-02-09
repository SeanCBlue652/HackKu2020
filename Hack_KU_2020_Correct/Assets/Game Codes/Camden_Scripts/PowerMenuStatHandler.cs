using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.ObjectModel;
using Sean.CharacterStats;

public class PowerMenuStatHandler : MonoBehaviour
{
    public GameObject PowerStatHandler;
    private handleStats Camden;

    // Start is called before the first frame update
    void Start()
    {
        //PowerStatHandler = GameObject.Find("StatsHandler");
        Camden = PowerStatHandler.GetComponent<handleStats>();
    }
    private ReadOnlyCollection<StatModifier> _mods  = Camden.getStatModifiers("Power");

    // Update is called once per frame
    void Update()
    {
        
    }
}
