using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{   public void NewGame()
    {
        SceneManager.LoadScene("Level1");
    }
    public void MenuLevel()
    {
        SceneManager.LoadScene("MenuLevel");
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
