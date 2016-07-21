using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fader : MonoBehaviour {

    public float fadeTime;
    // Use this for initialization


    private Image fadePanel;
    private Color currentColor = Color.black;

	void Start () {
        fadePanel = GetComponent<Image>();
        
    }
	
	// Update is called once per frame
	void Update () {
	    if (Time.timeSinceLevelLoad < fadeTime)
        {
            //Fade
            float alphaChange = Time.deltaTime / fadeTime;
            currentColor.a -= alphaChange;
            fadePanel.color = currentColor;

        }else
        {
            gameObject.SetActive(false);
        }
	}
}
