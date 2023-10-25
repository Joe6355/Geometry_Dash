using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class _Coins : MonoBehaviour
{
    public int coin = 0;
    public TMP_Text coinText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            coin++;
            coinText.text = coin.ToString();
            Destroy(collision.gameObject);
        }
    }

}
