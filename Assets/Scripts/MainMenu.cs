using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public GameObject sound;
    public Toggle soundCheck;
    public Slider soundSlider;
    public InputField charName;

    private void Start()
    {
        charName.text = PlayerPrefs.GetString("CharacterName");
    }

    public void CharNameChanged()
    {
        PlayerPrefs.SetString("CharacterName", charName.text);
        print(PlayerPrefs.GetString("CharacterName"));
    }

    public void SliderCheck()
    {
        sound.GetComponent<AudioSource>().volume = soundSlider.value;
    }

    public void SoundOnOff()
    {
        if (soundCheck.isOn)
        {
            sound.GetComponent<AudioSource>().volume = 1.0f;
        }
        else if (!soundCheck.isOn)
        {
            sound.GetComponent<AudioSource>().volume = 0.0f;
        }
    }
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Level2()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitGame()
    {
        Application.Quit();
        print("oyundan cikildi");
    }
}
