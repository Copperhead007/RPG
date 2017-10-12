using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest : Interactable {

	Animator animator;

	bool isOpen;
	public Item[] items;

	void Start() {
		animator = GetComponent<Animator> ();
	}

	public override void Interact ()
	{
		base.Interact ();
		if (!isOpen) {
			animator.SetTrigger ("Open");
			StartCoroutine (CollectTreasure ());
		}
	}

	IEnumerator CollectTreasure() {

		isOpen = true;
        int numItems = Random.Range(0, 4);
		yield return new WaitForSeconds (1f);
		print ("Chest opened");
		for(int y = 0; y<=numItems; y++)
        {
            Item i = items[Random.Range(0,6)];
			Inventory.instance.Add (i);
		}
	}
}
