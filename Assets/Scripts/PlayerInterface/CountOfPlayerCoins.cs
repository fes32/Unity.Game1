using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountOfPlayerCoins : MonoBehaviour
{
    [SerializeField] private Wallet _playerWallet;
    [SerializeField] private TMP_Text _countOfCoins;

    private void OnEnable()
    {
        _playerWallet.CoinsChanged += OnCountOfPlayerCoinChanged;
    }

    private void OnDisable()
    {
        _playerWallet.CoinsChanged -= OnCountOfPlayerCoinChanged;
    }

    private void OnCountOfPlayerCoinChanged(int count)
    {
        _countOfCoins.text = count.ToString();
    }
}