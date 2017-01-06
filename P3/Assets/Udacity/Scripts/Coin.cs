using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject coinPoofPrefab;

    public void OnCoinClicked() {
             
        Vector3 coinPos = transform.position;

        // Destroy this coin
        Destroy(transform.gameObject);

        // Instantiate the CoinPoof Prefab where this coin is located
        Instantiate(coinPoofPrefab, coinPos, Quaternion.identity);


        
    }

}
