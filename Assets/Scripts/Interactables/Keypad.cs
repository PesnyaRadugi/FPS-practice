using UnityEngine;


public class Keypad : Interactable
{
    [SerializeField] private GameObject door;
    private bool doorOpen;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    protected override void Interact()
    {
        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
    }
}
