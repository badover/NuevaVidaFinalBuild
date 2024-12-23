using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SubtitleManager : MonoBehaviour
{
    public Text subtitleText;
    public float displayTime = 5f; 

    private void Start()
    {
        subtitleText.text = "Привет"; 
    }

    public void ShowSubtitle(string text)
    {
        StartCoroutine(DisplaySubtitle(text));
    }

    private IEnumerator DisplaySubtitle(string text)
    {
        subtitleText.text = text;
        yield return new WaitForSeconds(displayTime);
        subtitleText.text = "Пока";
    }
}
