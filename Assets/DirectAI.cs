using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectAI : CharacterAI
{
    public override void Chase()
    {
        if(currentTarget != null)
        {
            if(Vector3.Distance(transform.position, currentTarget.position)> 1.0f)
            {
            
            moveToTarget(currentTarget.position, moveSpeed);
            }
        }
    }
   
}
