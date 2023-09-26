using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DiaManager : MonoBehaviour
{
    public int stageRewardDia = 1; // 스테이지를 깨면 주는 보상 다이아 임의 값 
    public TMP_Text diaText;

    private int currentDiamons = 0;// 현재 다이아 양

    void Start()
    {
        LoadDiamonds();
        UpdateDiaUI();
    }

    public void StageCleared()
    {
        currentDiamons += stageRewardDia;
        SaveDiamons();
        UpdateDiaUI();
    }

    void UpdateDiaUI()
    {
        diaText.text = ($"{currentDiamons}");
    }

    void SaveDiamons()
    {
        PlayerPrefs.SetInt("Diamonds", currentDiamons);
        PlayerPrefs.Save();
    }

    void LoadDiamonds()
    {
        currentDiamons = PlayerPrefs.GetInt("Diamonds", 0);
    }

}
