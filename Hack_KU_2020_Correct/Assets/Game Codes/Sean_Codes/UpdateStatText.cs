//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Sean.CharacterStats;

public class UpdateStatText : MonoBehaviour
{
    private Text _text;

    void Awake() {
        _text = GetComponent<Text>();
    }

    public void updateText(string input) {
        _text.text = input;
    }
}
