using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    [SerializeField] internal string promptMessage;
    
    public void BaseInteract()
    {
        Interact();
    }

    protected virtual void Interact()
    {
        // Func for subclass
    }
}