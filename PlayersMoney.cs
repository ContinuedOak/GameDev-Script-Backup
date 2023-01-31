using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayersMoney : MonoBehaviour
{
    [Header("Cash")]
    public int Cash = 0;
    [SerializeField] private Text CashHud;
    [SerializeField] private Text CashStats;

    [Header("Bank")]
    public int Bank = 2448;
    [SerializeField] private Text BankHud;
    [SerializeField] private Text BankStats;

    void Update()
    {
        CashHud.text = Cash.ToString();
        CashStats.text = Cash.ToString();
        BankHud.text = Bank.ToString();
        BankStats.text = Bank.ToString();

    }
}
//Random.Range(25f, 65f)