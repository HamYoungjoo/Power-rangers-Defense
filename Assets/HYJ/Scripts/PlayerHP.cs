using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    private int maxHP = 5; //플레이어 목숨 (타워 벽에 몬스터 닿을 시 줄어드는)
    private int currentHP;

    public GameObject PlayerHpPrefab;
    public Transform PlayerHpPos;

    public int MaxHP => maxHP;
    public int CurrentHP => currentHP;

    private void Start()
    {
        currentHP = maxHP;

        for (int i = 0; i < maxHP; i++)
        {
            GameObject hpImage = Instantiate(PlayerHpPrefab, PlayerHpPos);
        }
    }

    //public void MonsterReachedGoal(int damage)
    //{
    //    if (currentHP > 0)
    //    {
    //        currentHP -= damage;
    //        hpImages[currentHP].SetActive(false);

    //        if (currentHP <= 0)
    //        {
    //            GameOver();
    //        }
    //    }
    //}

    //private void GameOver()
    //{
    //    Debug.Log("게임 오버!"); // 이후 게임 오버 패널 .
    //}
}