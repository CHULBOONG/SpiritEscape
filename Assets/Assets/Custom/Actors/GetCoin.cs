using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class GetCoin : MonoBehaviour
{
    public static int _coins = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("coin"))
        {
            ++_coins;
            Destroy(other.gameObject);
        }
    }
}
