using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void LevelSelect()
    {
        SceneManager.LoadScene("Selectlevel");
    }

    public void Map1()
    {
        SceneManager.LoadScene("Firstjumpmap");
    }

    public void Map2()
    {
        SceneManager.LoadScene("2");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}