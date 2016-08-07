using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {

    public Slider volumeSlider;
    public Slider difficultySlider;
    public LevelManager levelManager;

    private MusicManager musicManager;
	// Use this for initialization
	void Start () {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        Debug.Log(musicManager);
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        difficultySlider.value = PlayerPrefsManager.GetDifficulty();
        Debug.Log(PlayerPrefsManager.GetMasterVolume());
    }
	
    public void SaveAndExit()
    {

        Debug.Log(volumeSlider.value);
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
        PlayerPrefsManager.SetDifficulty(difficultySlider.value);
        Debug.Log(PlayerPrefsManager.GetMasterVolume());
        levelManager.LoadLevel("01a Start");
        
    }

	// Update is called once per frame
	void Update () {
        musicManager.ChangeVolume(volumeSlider.value);
	}

    public void SetDefaults()
    {
        PlayerPrefsManager.SetMasterVolume(1);
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        PlayerPrefsManager.SetDifficulty(1);
        difficultySlider.value = PlayerPrefsManager.GetDifficulty();

    }
}
