using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private GameManager manager;
    [SerializeField] private int scoreToGive;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (this.tag == "Player" && other.transform.tag == "Coin")
        {
            manager.AddScore(scoreToGive);
            Destroy(other.gameObject);
        }
    }

}
