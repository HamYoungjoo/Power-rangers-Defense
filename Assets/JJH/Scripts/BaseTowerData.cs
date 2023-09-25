using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public abstract class BaseTowerData : MonoBehaviour //이거를 붙혀도
{
    public string towerName { get; set; }
    public float att { get; set; }
    public float attDelay { get; set; }
    public float hp { get; set; }


    public BaseTowerData(string _name, float _att, float _attDelay, float _hp)
    {
        towerName = _name;
        att = _att;
        attDelay = _attDelay;
        hp = _hp;
    }

    public void TowerGetDmg(float monsterAttValue)
    {
        //todo
    }

    public void TowerGiveDmg(int _towerAttVlaue)
    {
        //todo
    }
}

public class BlackRanger : BaseTowerData
{
    public BlackRanger(string _name, float _att, float _attDelay, float _hp) : base(_name, _att, _attDelay, _hp)
    {
        
    }
}

public class RedRanger : BaseTowerData
{
    public RedRanger(string _name, float _att, float _attDelay, float _hp) : base(_name, _att, _attDelay, _hp)
    {

    }

    public float ReflexDamageCalc(float _enemyAttValue)
    {
        float redHp = hp;
        return redHp / _enemyAttValue;
    }
}

public class PinkRanger : BaseTowerData 
{
    public float heal { get; set; }

    public PinkRanger (string _name, float _att, float _attDelay, float _hp, float _heal) : base(_name, _att, _attDelay, _hp)
    {
        heal = _heal;
    }
}

public class GreenRanger : BaseTowerData
{
    public float attRangeMultiple { get; set; }

    public GreenRanger(string _name, float _att, float _attDelay, float _hp, float _attRangeMultiple) : base(_name, _att, _attDelay, _hp)
    {
        attRangeMultiple = _attRangeMultiple;
    }
}

public class BlueRanger : BaseTowerData
{
    public float slowTime { get; set; }
    public float slowRange { get; set; }

    public BlueRanger(string _name, float _att, float _attDelay, float _hp, float _slowTime) : base(_name, _att, _attDelay, _hp)
    {
        slowTime = _slowTime;
    }

    public IEnumerator EnemyMovSpeedSlorRange()
    {
        yield return new WaitForSeconds(2f);
    }
}
