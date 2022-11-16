using UnityEngine;


public class ChangeColourCube : Interactable
{
    [Header("Set of colors to swap between")]
    [SerializeField] private Color[] colors;
    private MeshRenderer mesh;
    private int colorIndex;
    
    
    private void Start()
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
