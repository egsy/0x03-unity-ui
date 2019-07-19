using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public Material trapMat;
    public Material goalMat;
    public Toggle colorblindMode;

    /// <summary>
    /// 
    /// </summary>
    public void PlayMaze()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        if (colorblindMode == true)
        {
            trapMat.color = new Color32(255, 112, 0, 1);
            goalMat.color = Color.blue;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public void QuitMaze()
    {
        Debug.Log("Quit Game");
    }
}
