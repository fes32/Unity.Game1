using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WalletPresenter : MonoBehaviour
{
    [SerializeField] private Wallet _wallet;
    [SerializeField] private TMP_Text _coins;

    private void OnEnable()
    {
        _wallet.CoinsChanged += OnCountOfPlayerCoinChanged;
    }

    private void OnDisable()
    {
        _wallet.CoinsChanged -= OnCountOfPlayerCoinChanged;
    }

    private void OnCountOfPlayerCoinChanged(int count)
    {
        _coins.text = count.ToString();
    }
}