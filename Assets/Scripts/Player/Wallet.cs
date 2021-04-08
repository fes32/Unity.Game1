using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Wallet : MonoBehaviour
{
    public int Coins { get; private set; } = 0;

    public event UnityAction<int> CoinsChanged;

    public void CoinAdded()
    {
        Coins++;
        CoinsChanged?.Invoke(Coins);
    }
}