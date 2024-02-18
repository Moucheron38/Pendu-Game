using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Words
{
    private List<string> listWords;
    public string curWord;
    

    public Words(List<string> listWords)
    {
        this.listWords = listWords;
        GetWord();
    }
    public Words(string word)
    {
        curWord = word;
    }

     string GetWord()
    {
        curWord = listWords[Random.Range(0, listWords.Count)];
        listWords.Remove(curWord);
        return curWord;
        
    }

    public bool ContainsLetter(char letter)

    {
        return curWord.Contains(letter);
    }

    
}

