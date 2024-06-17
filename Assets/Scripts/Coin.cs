using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private char coinName;
    public int coinValue;

    // Start is called before the first frame update
    void Start()
    {
        coinName = name[0];

        switch (coinName)
        {
            case 'S':
                coinValue = 1;
                break;
            case 'G':
                coinValue = 2;
                break;
        }
    }
}
