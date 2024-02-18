using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class IHM : MonoBehaviour
{
    [SerializeField] Image hangmanIMG;
    public TMP_Text txt;

    private bool win = false;
    public Sprite[] sp;
    public GameObject pendu;
    private int i = 0;
    public GameObject panelEnd;
    public AudioClip sfxOkay, sfxFailed;
    public AudioSource audiosource;
    public TMP_Text txtLetterPlayed;
    public TMP_Text txtScore;


    Game currentGame
    {
        get
        {
            return GameManager.instance.currentGame;
        }
    }

    public static IHM instance;

    private void Awake()
    {
        instance = this;
        
    }

    void DisplayPlayedLetters()
    {
        string playedLettersstr = string.Empty;

        foreach (var item in currentGame.playedLetters)
        {
            playedLettersstr += item + ",";
        }
        txtLetterPlayed.text = " Lettres déjà jouées : " + playedLettersstr;
    }

    void DisplayWord()

    {
        string word = string.Empty;
        char _char;

        for (int i = 0; i < currentGame.word.curWord.Length; i++)
        {
            _char = currentGame.word.curWord[i];

            word += currentGame.playedLetters.Contains(_char) ? _char : "_";

        }

        txt.text = word;
        
    }

    public void UpdateHangmanSprite()

    {
        int index = currentGame.maxLife - currentGame.currentLife;
        hangmanIMG.sprite = sp[index];

        
    }

    public void Refresh()
    {
        UpdateHangmanSprite();
        DisplayWord();
        DisplayPlayedLetters();
        UpdateScore();

        if (currentGame.isGameOver) OnGameOver();
        
        
    }

    
    void OnGameOver()
    {
        panelEnd.SetActive(true);
        audiosource.PlayOneShot(sfxFailed);
    }

    void UpdateScore()
    {
        txtScore.text = "Score : " + GameManager.instance.currentUser.score;
    }

    




}
