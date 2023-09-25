using System.Collections;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private enum MonsterType { Pink = 1, Owlet, Dude }
    [SerializeField] private MonsterType monsterType;

    private Rigidbody2D _rigid;

    public int curHealth;
    public int maxHealth;
    private int attackDamage;
    private float moveSpeed;
    public int goldPerKill;

    private bool IsDeath;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        IsDeath = false;
        curHealth = maxHealth;

        switch (monsterType)
        {
            case MonsterType.Pink:
                maxHealth = 200;
                attackDamage = 5;
                moveSpeed = 20f;
                goldPerKill = 5;
                break;
            case MonsterType.Owlet:
                maxHealth = 300;
                attackDamage = 15;
                moveSpeed = 10f;
                goldPerKill = 15;
                break;
            case MonsterType.Dude:
                maxHealth = 100;
                attackDamage = 10;
                moveSpeed = 30f;
                goldPerKill = 10;
                break;
        }
    }

    private void FixedUpdate()
    {
        if (IsDeath) return;

        _rigid.velocity = Vector2.left * moveSpeed * Time.fixedDeltaTime;
    }
  
}
