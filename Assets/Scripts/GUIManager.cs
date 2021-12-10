using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void NewGame()
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
}