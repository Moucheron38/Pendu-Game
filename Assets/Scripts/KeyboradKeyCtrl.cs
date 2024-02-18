using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyboradKeyCtrl : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI letter;
    [SerializeField] string buttonLetter;

    public void Init(string letter)
    {
        buttonLetter = letter;
        this.letter.text = letter;
    }

    public void OnClick()
    {
        
        GameManager.instance.Validation(buttonLetter);
    }

  
   

    
    
}
