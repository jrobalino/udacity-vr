﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject coinPoofPrefab;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located

        Vector3 coinPos = transform.position;
        Destroy(transform.gameObject);
        Instantiate(coinPoofPrefab, coinPos, Quaternion.identity);


        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
    }

}
