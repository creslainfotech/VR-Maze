using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject coinPoofPrefab;
    public GameObject coin;

    public AudioClip myclip;
    public float speed = 10f;
    void start()
    {
         this.gameObject.AddComponent<AudioSource>();
         this.GetComponent<AudioSource>().clip = myclip;
         this.GetComponent<AudioSource>().Play();
    }
    public void OnCoinClicked() {
       
        Instantiate(coinPoofPrefab,transform.position,Quaternion.Euler(-90,0,0));
        Destroy(coin);
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
    }

}
