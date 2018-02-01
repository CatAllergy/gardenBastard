using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

    public Slider Volume_Slider;
    public Slider Difficulty_Slider;
    public LevelManager levelManager;
 

    private MusicManager musicManager;
	// Use this for initialization
	void Start () {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        print(musicManager);
        Volume_Slider.value = PlayerPrefsManager.GetMasterVolume();
        Difficulty_Slider.value = PlayerPrefsManager.GetDifficulty();
	}
	
    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(Volume_Slider.value);
        PlayerPrefsManager.SetDifficulty(Difficulty_Slider.value);
        levelManager.LoadLevel("01a Start");
    }

    private void Update()
    {
        musicManager.ChangeVolume(Volume_Slider.value);
    }

    public void SetDefaults()
    {
        Volume_Slider.value = 0.8f;
        Difficulty_Slider.value = 1f;
    }
}
