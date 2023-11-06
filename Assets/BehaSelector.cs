using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaSelector : MonoBehaviour
{
    public enum State
    {
        Chase,
        Flee,
        Wander
    }
   
    CharacterAI aiController;

    void Awake()
    {
        aiController = GetComponent<CharacterAI>();
        aiController.currentTarget = GameObject.FindGameObjectWithTag("Player").transform;

    }
    void Update()
    {
        switch (aiController.currentState)
        {
            
            case State.Chase:
            aiController.Chase();
            break;
            case State.Flee:
            aiController.Flee();
            break;
        }
    }
}
