using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateCube : Interactable
{
    private Animator animator;
    private string startPrompt;
    private void Start()
    {
        animator = GetComponent<Animator>();
        startPrompt = promptMessage;
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("CubeDefault"))
        {
            promptMessage = startPrompt;
        }
        else
        {
            promptMessage = "Animating... (Press E to stop)";
        }
    }

    protected override void Interact()
    {
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("CubeDefault"))
        {
            animator.Play("CubeSpin");
        }
        else
        {
            animator.Play("CubeDefault");
        }
    }
}
