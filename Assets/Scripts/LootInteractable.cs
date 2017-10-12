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
    }

}
