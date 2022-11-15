using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColourCube : Interactable
{
    private MeshRenderer mesh;
    [SerializeField] private Color[] colors;
    private int colorIndex;
    
    
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mesh.material.color = Color.black;
    }

    protected override void Interact()
    {
        colorIndex++;
        if (colorIndex > colors.Length - 1)
        {
            colorIndex = 0;
        }
        mesh.material.color = colors[colorIndex];
    }
}
