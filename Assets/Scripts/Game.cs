using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    /*[SerializeField]
    private Text hitsText;
    [SerializeField]
    private Text shotsText;*/
    [SerializeField]
    private GameObject menu;
    [SerializeField]
    private GameObject[] targets;
    private bool isPaused = false;


    void Start()
    {
        // Cursor.lockState = CursorLockMode.Confined;
        menu.SetActive(false);
    }

    public void Pause()
    {
        menu.SetActive(true);
        Cursor.visible = true;
        Time.timeScale = 0;
        isPaused = true;
    }

    public void Unpause()
    {
        menu.SetActive(false);
        Cursor.visible = false;
        Time.timeScale = 1;
        isPaused = false;
    }

    public bool IsGamePaused()
    {
        return isPaused;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isPaused)
            {
                Unpause();
            }
            else
            {
                Pause();
            }
        }
    }

    public void NewGame()
    {

       

        Unpause();
        SceneManager.LoadScene("Intro");
    }


    public static void SaveData(PlayerLives playerLives)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/playerLives.save";
        FileStream stream = new FileStream(path, FileMode.Create);
        Save save = new Save();
        formatter.Serialize(stream, save);
        stream.Close();
    }


     private Save CreateSaveGameObject()
     {
         Save save = new Save();

         return save;
     }

      public void SaveAsJSON()
     {
         Save save = CreateSaveGameObject();
         string json = JsonUtility.ToJson(save);

         Debug.Log("Saving as JSON: " + json);
     }



    public void LoadGame()
     {

        string path = Application.persistentDataPath + "/playerLives.save";
        if (File.Exists(path))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open( path, FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();
            Debug.Log("Game Loaded");

            Unpause();

        }

        else
        {
            Debug.Log("No game saved!");
        }

    }

    /* public static Save LoadPlayerLives()
 {
     string path = Application.persistentDataPath + "/playerLives.save";
     if (File.Exists(path))
     {
         BinaryFormatter formatter = new BinaryFormatter();
         FileStream stream = new FileStream(path, FileMode.Open);
         Save save = formatter.Deserialize(stream) as Save;
         stream.Close();
         return save;
     }
     else
     {
         Debug.LogError("Save file not found in " + path);
         return null;
     }
 }*/


    /* public void SaveGame()
     {
         // 1
         Save save = CreateSaveGameObject();

         // 2
         BinaryFormatter bf = new BinaryFormatter();
         FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
         bf.Serialize(file, save);
         file.Close();

         // 3
         hits = 0;
         shots = 0;
         shotsText.text = "Shots: " + shots;
         hitsText.text = "Hits: " + hits;

         ClearRobots();
         ClearBullets();
         Debug.Log("Game Saved");
     }*/
}
