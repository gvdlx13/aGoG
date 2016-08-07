using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print(PlayerPrefsManager.GetMasterVolume());
        PlayerPrefsManager.SetMasterVolume(0.3f);
        print(PlayerPrefsManager.GetMasterVolume());

        print(PlayerPrefsManager.IsLevelUnlocked(2));
        PlayerPrefsManager.UnlockLevel(2);
        print(PlayerPrefsManager.IsLevelUnlocked(2));

    }
	
}
