using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    BaseTowerData btd;
    [SerializeField] private RedRanger redRanger;
    [SerializeField] private BlueRanger blueRanger;
    [SerializeField] private BlackRanger blackRanger;
    [SerializeField] private GreenRanger greenRanger;
    [SerializeField] private PinkRanger pinkRanger;


    void Awake()
    {
        //                              name, attValue, attDelay, hp, 
        redRanger = new RedRanger    ("RedRanger",   0f, 2f, 10f);
        blueRanger = new BlueRanger  ("BlueRanger",  1f, 3f, 5f, 2f);
        greenRanger = new GreenRanger("GreenRanger", 2f, 5f, 4f, 3f);
        blackRanger = new BlackRanger("BlackRanger", 1f, 2f, 6f);
        pinkRanger = new PinkRanger  ("PinkRanger",  1f, 2f, 8f, 1f);


    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
