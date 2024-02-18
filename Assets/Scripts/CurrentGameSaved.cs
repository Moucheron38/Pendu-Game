using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CurrentGameSaved
{
    public int life;
    public List<char> playedLetters;
    public string currentWord;
    

    public CurrentGameSaved(Game game)
    {
        SaveCurrentGame(game);
    }
    public void SaveCurrentGame(Game game)
    {
        playedLetters = game.playedLetters;
        life = game.currentLife;
        currentWord = game.word.curWord;
    }


}
