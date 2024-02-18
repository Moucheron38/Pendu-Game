using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardCtrl : MonoBehaviour
{
    [SerializeField] GameObject buttonPrefab;
    [SerializeField] List<string> letters;
    [SerializeField] Transform panel;

    void Start()
    {
        CreateKeyboard();
    }

    void CreateKeyboard()
    {
        foreach(string letter in letters)
        {
            GameObject instance = Instantiate(buttonPrefab, panel);
            KeyboradKeyCtrl keyCtrl = instance.GetComponent<KeyboradKeyCtrl>();
            keyCtrl.Init(letter);


        }
    }
    
 

}
