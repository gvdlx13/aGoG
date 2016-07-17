using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicChangeArray;
    // Use this for initialization
    private AudioSource audioSource;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Don't Destory on Load" + name);
        audioSource = GetComponent<AudioSource>();
    }

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnLevelWasLoaded(int level)
    {
        AudioClip thisLevelMusic = levelMusicChangeArray[level];
        Debug.Log("Playing clip:" + thisLevelMusic);
        if (thisLevelMusic)
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }
}
