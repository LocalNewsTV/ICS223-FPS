using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
    public void ReactToHit()
    {
        WanderingAI enemyAI = GetComponent<WanderingAI>();
        if (enemyAI != null)
        {
            enemyAI.ChangeState(EnemyStates.dead);
        }
        Animator enemyAnimator = GetComponent<Animator>();
        if (enemyAnimator != null)
        {
            enemyAnimator.SetTrigger("die_trig");
        }
    }
    private void DeadEvent() 
    {
        Destroy(this.gameObject);
    }
}
