/*
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade1 : MonoBehaviour
{
    public Image fadeImage;
    private bool isFadingOut = false;
    private bool isFadingIn = false;
    private float fadeDuration = 5f;

    void Start()
    {
        fadeImage.color = new Color(0, 0, 0, 1);
        StartCoroutine(FadeIn());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && !isFadingOut)
        {
            StartCoroutine(FadeOut());
        }
    }

    IEnumerator FadeOut()
    {
        isFadingOut = true;
        float fadeSpeed = 1f / fadeDuration;
        for (float t = 0.01f; t < fadeDuration; t += Time.deltaTime)
        {
            fadeImage.color = new Color(0, 0, 0, Mathf.Lerp(0, 1, t * fadeSpeed));
            yield return null;
        }
        fadeImage.color = new Color(0, 0, 0, 1);
        PlayerPrefs.SetInt("FadeState", 1);
        SceneManager.LoadScene("NextScene");
    }

    IEnumerator FadeIn()
    {
        if (PlayerPrefs.GetInt("FadeState", 0) == 1)
        {
            isFadingIn = true;
            float fadeSpeed = 1f / fadeDuration;
            for (float t = 0.01f; t < fadeDuration; t += Time.deltaTime)
            {
                fadeImage.color = new Color(0, 0, 0, Mathf.Lerp(1, 0, t * fadeSpeed));
                yield return null;
            }
            fadeImage.color = new Color(0, 0, 0, 0);
            PlayerPrefs.SetInt("FadeState", 0);
        }
    }
}
*/