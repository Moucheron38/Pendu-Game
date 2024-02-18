using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Game
{
    public Words word;
    public List<char> playedLetters;
    public int maxLife;
    public int currentLife;
    //Ceci est un constructeur
    
    
    public Game(CurrentGameSaved save)
    {
        word = new Words(save.currentWord);
        playedLetters = save.playedLetters;
        maxLife = 6;
        currentLife = save.life;
    }
    public Game(GameManager instance)
    {
        
        
        word = new Words(instance.listWords);
        playedLetters = new List<char>();
        maxLife = 6;
        currentLife = maxLife;
        UserHolder.instance.user.usedWords.Add(word.curWord);
        
    }

    public bool isGameWon
    {
        get
        {
            for (int i = 0; i < word.curWord.Length; i++)
            {
                if (!playedLetters.Contains(word.curWord[i])) return false;

            }


            
            
            return true;

        }
    }

    public bool isGameOver
    {
        get
        {
            return (currentLife <= 0);

        }
    }


    


}

