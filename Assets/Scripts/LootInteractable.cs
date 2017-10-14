using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootInteractable : Interactable
{

    public Item[] items;

    void Start()
    {
       // animator = GetComponent<Animator>();
    }

    public override void Interact()
    {
        base.Interact();
        int numItems = Random.Range(0, 4);
        for (int y = 0; y <= numItems; y++)
        {
            Item i = items[Random.Range(0, 3)];
            Inventory.instance.Add(i);
        }
    }

}
