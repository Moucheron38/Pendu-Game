using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SavedSlotCtrl : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI userName, bestScore, savedUserName;

    User refUser;



    public void Init(User user)
    {
        refUser = user;
        userName.text = refUser.userName;
        bestScore.text = refUser.score.ToString();
        

    }

    public void OnClick()
    {
        
        ProfileSelectionCtrl.instance.AssignUser(refUser);
        


        ChosenProfileCtrl.UpdateChosenProfile(refUser);
        

    }

    

}
