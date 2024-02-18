using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ProfileSelectionCtrl : MonoBehaviour
{
    public GameObject newProfil;
    public GameObject chooseProfil;
    public GameObject profilSelected;
    [SerializeField] TextMeshProUGUI startButtonText;
    public static ProfileSelectionCtrl instance;

    private void Awake()
    {
        instance = this;
    }
    public void AssignUser(User user)
    {
        UserHolder.instance.user = user;
        newProfil.SetActive(false);
        profilSelected.SetActive(true);
        startButtonText.text = (user.score == 0) ? "Nouvelle Partie" : "Continuer";
    }

    public void CreateNewProfil()
    {
        chooseProfil.SetActive(false);
        newProfil.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
        
    }
}
