using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int goldReward =25;
    [SerializeField] int goldPenalty =25;

    Bank bank;

    // Start is called before the first frame update
    void Start()
    {
        bank = FindObjectOfType<Bank>();
    }

    public void RewardGold()
    {
        bank.Deposit(goldReward);
    }

    public void StoleGold()
    {      
        bank.Withdraw(goldPenalty);
    }

}
