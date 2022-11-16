using UnityEngine;
using TMPro;


public class PlayerUI : MonoBehaviour
{
    [Header("PlayerUI settings")]
    [SerializeField] private TextMeshProUGUI promptText;


    private void Start()
    {
        
    }

    internal void UpdateText(string promptMessage)
    {
        promptText.text = promptMessage;
    }
}
