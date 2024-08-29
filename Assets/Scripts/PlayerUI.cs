using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI promptTxt;

    private void Start()
    {

    }
    public void UpdateText(string promptMessage)
    {
        promptTxt.text = promptMessage;
    }
}
