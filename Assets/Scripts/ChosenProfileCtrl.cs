using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChosenProfileCtrl : MonoBehaviour
{
    [SerializeField] TMP_Text username;
    [SerializeField] TMP_Text bestScore;

    public static ChosenProfileCtrl instance;

    private void Awake()
    {
        instance = this;
    }

    public static void UpdateChosenProfile(User user)
    {
        instance.username.text = " Profil : " + user.userName;
        instance.bestScore.text = "Best Score : " + user.score.ToString();

    }
}
