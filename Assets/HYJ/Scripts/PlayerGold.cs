using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerGold : MonoBehaviour
{
   
    private int currentGold = 0; // 처음 주어질 골드의 양 

    public TMP_Text goldText;

    void Start()
    {
        UpdateGoldUI();    
    }

    public void AddGold(int amount)
    {
        currentGold += amount; // 몬스터가 죽으면 나올 골드를 더해준다
        UpdateGoldUI();
    }

    void UpdateGoldUI()
    {
        goldText.text = currentGold + " G";
    }
}
