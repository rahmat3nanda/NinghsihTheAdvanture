using System.Collections;
using Model;
using Model.App;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScript : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(LoadData());
    }

    private IEnumerator LoadData()
    {
        var d = PlayerPrefs.GetString("player_data");
        var player = d == "" ? new PlayerModel(0, 1, 0f) : PlayerModel.FromJson(d);
        SingletonModel.GetInstance.SetPlayer(player);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Menu");
    }
}