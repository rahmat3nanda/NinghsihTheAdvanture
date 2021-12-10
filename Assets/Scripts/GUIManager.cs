using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{   public void newgame()
    {
        SceneManager.LoadScene("Level1");
    }
    public void menulevel()
    {
        SceneManager.LoadScene("MenuLevel");
    }
    public void level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void level2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void menu()
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
