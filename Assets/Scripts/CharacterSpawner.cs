using UnityEngine;
using UnityEngine.SceneManagement;
/*Adı Soyadı:Melike Duman
Öğrenci Numarası:262484053 
 */

public class CharacterSpawner : MonoBehaviour
{

    public GameObject[] characters;
    int index = 0;

    void Start()
    {
        index = CharacterSelection.currentIndex;
        Debug.Log("Index:" + index);
        int selected = index;

        if(selected>=0 && selected < characters.Length)
        {
            GameObject selectedCharacterPrefab = characters[selected];
            Instantiate(selectedCharacterPrefab,transform.position,Quaternion.identity);

        }
       else
        {
            Debug.Log("Index değeri hatalı");
        }
    }
     public void RestartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }
}
