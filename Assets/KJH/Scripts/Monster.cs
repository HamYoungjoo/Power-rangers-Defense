using System;
using System.Collections;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private enum MonsterType { Pink = 1, Owlet, Dude }
    [SerializeField] private MonsterType monsterType;

    private Rigidbody2D _rigid;

    [HideInInspector]
    public int curHealth;
    [HideInInspector]
    public int maxHealth;
    private int attackDamage;
    private float attackDelay;
    private float moveSpeed;
    private int goldPerDeath;

    private bool IsDeath;
    private bool IsAttacking;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        IsDeath = false;
        IsAttacking = false;
        curHealth = maxHealth;

        switch (monsterType)
        {
            case MonsterType.Pink:
                maxHealth = 200;
                attackDamage = 5;
                attackDelay = 1f;
                moveSpeed = 20f;
                goldPerDeath = 5;
                break;
            case MonsterType.Owlet:
                maxHealth = 300;
                attackDamage = 15;
                attackDelay = 2f;
                moveSpeed = 10f;
                goldPerDeath = 15;
                break;
            case MonsterType.Dude:
                maxHealth = 100;
                attackDamage = 10;
                attackDelay = 0.5f;
                moveSpeed = 30f;
                goldPerDeath = 10;
                break;
        }
    }

    private void FixedUpdate()
    {
        ApplyMove();        
    }

    private void ApplyMove()
    {
        if (IsDeath || IsAttacking)
        {
            _rigid.velocity = Vector2.zero;
        }
        else
        {
            _rigid.velocity = Vector2.left * moveSpeed * Time.fixedDeltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Defender")
        {
            IsAttacking = true;
            Debug.Log("타워 충돌");
            GiveAttack();
        }
        else if (other.tag == "Earth")
        {
            // gameObject.SetActive(false);
            // spawnmanager 에게 반환
            // 플레이어 피 감소
        }
        else return;            
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Defender")
        {
            IsAttacking = false;
        }
        else return;
    }

    private void GiveAttack()
    {
        // attack anim
        // 데미지 주기 + attackDealy 만큼 대기
    }

    public void TakeDamage(int _damage)
    {
        curHealth -= _damage;
        // hit anim
        if (curHealth <= 0)
        {
            // Death anim
            // player 골드 증가 (goldperkill)
            // Destroy - anim event
        }
    }
}
