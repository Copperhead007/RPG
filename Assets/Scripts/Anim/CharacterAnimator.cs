using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterAnimator : MonoBehaviour {
	
	public Animator animator;

    public float chngVal;

	NavMeshAgent navmeshAgent;
	CharacterCombat combat;

	protected virtual void Start() {
		navmeshAgent = GetComponent<NavMeshAgent> ();
		combat = GetComponent<CharacterCombat> ();
		combat.OnAttack += OnAttack;
	}

	protected virtual void Update () {
		//animator.SetFloat ("Speed Percent", navmeshAgent.velocity.magnitude/navmeshAgent.speed,.1f,Time.deltaTime);
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            animator.SetFloat("Speed Percent", chngVal, .1f, Time.deltaTime);
        }
        else
        {
            animator.SetFloat("Speed Percent", 0.0f, .1f, Time.deltaTime);
        }
    }

	protected virtual void OnAttack() {
		animator.SetTrigger ("Attack");
	}
}
