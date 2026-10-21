using UnityEngine;
using UnityEngine.SceneManagement;
/*Adı Soyadı:Melike Duman
Öğrenci Numarası:262484053 
 */

public class MainMenu : MonoBehaviour
{
   public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

     public void QuıtToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }


}
