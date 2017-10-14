using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimator : MonoBehaviour {

    public Animator animator;

    public float chngVal;

    //NavMeshAgent navmeshAgent;
    CharacterCombat combat;

    protected virtual void Start()
    {
        //navmeshAgent = GetComponent<NavMeshAgent> ();
        combat = GetComponent<CharacterCombat>();
        combat.OnAttack += OnAttack;
    }

    protected virtual void Update()
    {
        //animator.SetFloat ("Speed Percent", navmeshAgent.velocity.magnitude/navmeshAgent.speed,.1f,Time.deltaTime);
        //animator.SetFloat("Speed Percent", 0.0f, .1f, Time.deltaTime);
       
    }

    protected virtual void OnAttack()
    {
        animator.SetTrigger("Attack");
    }
}
