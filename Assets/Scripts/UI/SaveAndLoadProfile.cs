using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveAndLoadProfile : MonoBehaviour
{
    string path;
    [SerializeField] GameObject savedSlot;
    [SerializeField] GameObject parent;
    [SerializeField] GameObject profilMenu;

    public void Start()
    {
        path = Application.persistentDataPath + "/Saves";
        
    }
    public void Save()
    {
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);

        UserHolder.instance.user.currentGameSaved = new CurrentGameSaved(GameManager.instance.currentGame);
        string json = JsonUtility.ToJson(UserHolder.instance.user);
        File.WriteAllText(path + $"/{UserHolder.instance.user.userName}.txt", json);
    }

    public List<User> GetAllSavedUsers()
    {
       

        DirectoryInfo dinfo = new DirectoryInfo(path);
        FileInfo[] files = dinfo.GetFiles("*.txt");

        Debug.Log(files.Length);

        List<User> usersList = new List<User>();

        foreach(FileInfo file in files)
        {
            // Open the file to read from.
            using (StreamReader sr = file.OpenText())
            {
                string data = sr.ReadLine();
                Debug.Log(data);
                User loadedUser = JsonUtility.FromJson<User>(data);
                usersList.Add(loadedUser);


                GameObject inst = Instantiate(savedSlot);
                inst.transform.SetParent(parent.transform);
                SavedSlotCtrl slotCtrl = inst.GetComponent<SavedSlotCtrl>();
                slotCtrl.Init(loadedUser);
            }

        }

        return usersList;
    }

    public void LoadUser()
    {
        GetAllSavedUsers();
       

        profilMenu.SetActive(false);
        parent.SetActive(true);
        
    }

    
}
