using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class User
{
    [SerializeField] public string userName;
    [SerializeField] public int score;
    [SerializeField] public List<string> usedWords;
    [SerializeField] public CurrentGameSaved currentGameSaved = null;
    

    public User(string userName)
    {
        this.userName = userName;
        score = 0;
        usedWords = new List<string>();
    }


    
}
