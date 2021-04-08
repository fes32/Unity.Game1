using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(Wallet))]
public class Player : MonoBehaviour
{
    private PlayerMovement _movement;
    private Wallet _coinsWallet;

    public event UnityAction Died; 

    private void OnEnable()
    {
        _movement = GetComponent<PlayerMovement>();
        _coinsWallet = GetComponent<Wallet>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out Coin coin))
        {
            _coinsWallet.CoinAdded();
            coin.gameObject.SetActive(false);
        }

        else if (other.gameObject.GetComponent<Barrier>())
        {
            Died?.Invoke();
        }
    }
}