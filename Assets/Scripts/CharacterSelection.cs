using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*Adı Soyadı:Melike Duman
Öğrenci Numarası:262484053 
 */
public class CharacterSelection : MonoBehaviour
{
    public List<GameObject> characters = new List<GameObject>();
    public TextMeshProUGUI characterName;
    public Button selectButton;
    public static int currentIndex = 0;

    void Start()
    {
        UpdateCharacterDisplay();
        selectButton.onClick.AddListener(OnSelectButtonClicked);
    }

    // Update is called once per frame
     void UpdateCharacterDisplay()
    {
        foreach(var character in characters)
        {
            character.SetActive(false);
        }
        characters[currentIndex].SetActive(true);

        characterName.text = characters[currentIndex].name;

    }

    public void OnRightButtonClicked()
    {
        currentIndex = (currentIndex + 1) % characters.Count;
        UpdateCharacterDisplay();
    }
    public void OnLeftButtonClicked()
    {
        currentIndex = (currentIndex - 1) % characters.Count;
        UpdateCharacterDisplay();
    }
    void OnSelectButtonClicked()
    {
        SceneManager.LoadScene(2);
        PlayerPrefs.SetInt("SelectedCharacterIndex", currentIndex);
        PlayerPrefs.Save();
    }
}
