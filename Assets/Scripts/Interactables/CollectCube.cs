using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectCube : Interactable
{
    protected override void Interact()
    {
        Destroy(gameObject);
    }
}
