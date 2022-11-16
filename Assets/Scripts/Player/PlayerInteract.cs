using UnityEngine;


public class PlayerInteract : MonoBehaviour
{
    [Header("Interacion raycast parameters")]
    [SerializeField] private float raycastDistance = 3f;
    [SerializeField] private LayerMask interactLayer;
    private new Camera camera;
    private PlayerUI playerUI;
    private InputHandler inputHandler;

    private void Start()
    {
        camera = GetComponent<PlayerLook>().camera;
        playerUI = GetComponent<PlayerUI>();
        inputHandler = GetComponent<InputHandler>();
    }

    // Update is called once per frame
    private void Update()
    {
        playerUI.UpdateText(string.Empty);
        Ray ray = new Ray(camera.transform.position, camera.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * raycastDistance);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, raycastDistance, interactLayer))
        {
            if (hitInfo.collider.GetComponent<Interactable>() != null)
            {
                Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputHandler.onFoot.Interact.triggered)
                {
                    interactable.BaseInteract();
                }
            }
        }
    }
}
