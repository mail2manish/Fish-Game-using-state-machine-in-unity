using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterAI : MonoBehaviour
{
    [HideInInspector]
    public Transform currentTarget;

    public BehaSelector.State currentState;
    [SerializeField]
    protected float moveSpeed = 0.3f;
    [SerializeField]
    private float fleeDistance = 4.0f;
    public abstract void Chase();
    public virtual void Flee()
    {
        if(currentTarget != null)
        {
            if(Vector3.Distance(transform.position, currentTarget.position) < fleeDistance)
            {
           moveToTarget(currentTarget.position, -moveSpeed);
            }
            else
            {
                currentState = BehaSelector.State.Chase;
            }
            }
    }
    public void moveToTarget(Vector3 targetPos, float speed)
    {
         transform.position = Vector3.MoveTowards(transform.position, targetPos, speed*Time.deltaTime);
    }
}
