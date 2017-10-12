using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This makes our enemy interactable. */

[RequireComponent(typeof(CharacterStats))]
public class Enemy : Interactable {

    public Item[] items;
    public Transform enemyPoint;
    Vector3 deathPoint;
    public Object lootObject;


    CharacterStats stats;
	public RagdollManager ragdoll;

	void Start ()
	{
		stats = GetComponent<CharacterStats>();
		stats.OnHealthReachedZero += Die;
	}
   

    // When we interact with the enemy: We attack it.
    public override void Interact()
	{
		print ("Interact");
		CharacterCombat combatManager = Player.instance.playerCombatManager;
		combatManager.Attack(stats);
	}

	void Die() {

        deathPoint = enemyPoint.position;
        deathPoint = new Vector3(deathPoint.x, deathPoint.y+.5f, deathPoint.z);
        Instantiate(lootObject, deathPoint, Quaternion.identity);
        ragdoll.transform.parent = null;
		ragdoll.Setup ();
        Destroy (gameObject);
	}

}
