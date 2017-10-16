using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootInteractable : Interactable
{

    public Item[] items;
    bool hasInteracted = false;
    void Start()
    {
       // animator = GetComponent<Animator>();
    }

    public override void Interact()
    {
        base.Interact();
        if(hasInteracted == false)
        {
            int numItems = Random.Range(0, 4);
            for (int y = 0; y <= numItems; y++)
            {
                Item i = items[Random.Range(0, 4)];
                Inventory.instance.Add(i);
            }
            hasInteracted = true;
        }
        else
        {
            return;
        }
        
    }

}
