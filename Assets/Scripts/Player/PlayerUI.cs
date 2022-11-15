using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI promptText;


    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    internal void UpdateText(string promptMessage)
    {
        promptText.text = promptMessage;
    }
}
