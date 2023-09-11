using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EarnAndSpend : MonoBehaviour
{
    public static int _balance = 0;
    public TMP_Text _text;

    // Update is called once per frame
    void Update()
    {
        if(_text != null)
        {
            _text.text = _balance.ToString();
        }
    }

    void Spend(int i)
    {
        _balance -= i;
    }
}
