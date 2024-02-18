using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<string> listWords = new List<string>();
    public User currentUser
    {
        get { return UserHolder.instance.user; }
    }

    public void KeyboardLetter(string letter)
    {
        Debug.Log(letter);
    }



    public Game currentGame;
    public static GameManager instance;




    private ScoreManager score;

    private void Awake()
    {
        instance = this;




        score = GetComponent<ScoreManager>();
    }

    private void Start()
    {
        if (currentUser.currentGameSaved == null)
            StartNewGame();
        else
            LoadFromSave();

    }

    public void StartNewGame()
    {
        currentGame = new Game(this);
        IHM.instance.Refresh();


    }

    public void LoadFromSave()
    {
        currentGame = new Game(currentUser.currentGameSaved);
        IHM.instance.Refresh();
    }



    public void Validation(string letter)
    {

        bool win = CheckCurrentLetter(letter);
        if (!currentGame.playedLetters.Contains(letter[0])) currentGame.playedLetters.Add(letter[0]);

        if (!win)
        {
            currentGame.currentLife--;
            //Perte de point de vie




        }

        else
        {
            if (currentGame.isGameWon)
            {
                currentUser.score++;
                StartNewGame();
                //Mot trouvé !
            }
        }












        IHM.instance.Refresh();
    }







    bool CheckCurrentLetter(string letter)
    {
        char _char = letter[0];


        if (currentGame.playedLetters.Contains(_char)) return false;



        if (!currentGame.word.ContainsLetter(_char)) return false;

        return true;
    }






}
