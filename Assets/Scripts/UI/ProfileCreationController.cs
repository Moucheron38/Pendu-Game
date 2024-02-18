using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProfileCreationController : MonoBehaviour
{
    [SerializeField] ProfileSelectionCtrl selectionController;
    [SerializeField] TMP_InputField usernameInputField;
    

    public static ProfileCreationController instance;

    private void Awake()
    {
        instance = this;
    }
    public void CreateProfile()
    {
        User user = new User(usernameInputField.text);
        selectionController.AssignUser(user);
    }

   

}
