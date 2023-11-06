using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacAI : CharacterAI
{
    public float wayPointRadius = 2.0f;
    private Vector3 wayPoint = Vector3.zero;
    private bool moveToWayPoint;
    public override void Chase()
    {
        if(Vector3.Distance(transform.position, currentTarget.position)> 2f)
        {
            wayPoint = currentTarget.position + Random.insideUnitSphere * wayPointRadius;
            wayPoint.y = currentTarget.position.y;
            moveToWayPoint = true;
        }
        if(moveToWayPoint)
        {
            //move to wayPoint
             if(Vector3.Distance(transform.position, wayPoint)> 0.01f)
            {
            moveToTarget(wayPoint, moveSpeed);
            }
            else
            {
                moveToWayPoint = false;
            }
        }
        if(!moveToWayPoint)
        {
            //move to player
             if(Vector3.Distance(transform.position, currentTarget.position)> 1.0f)
            {
                     moveToTarget(currentTarget.position, moveSpeed);
            }

        }
        
    }
    
}
