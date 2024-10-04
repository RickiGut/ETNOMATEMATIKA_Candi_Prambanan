using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class splashScreenManager : MonoBehaviour
{
    public Slider loadingSlider;

    void Start()
    {
        StartCoroutine(LoadingScene());
    }

    IEnumerator LoadingScene()
    {
        float duration = 2f;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime; 
            loadingSlider.value = Mathf.Clamp01(elapsedTime / duration);

            yield return null;
        }

        SceneManager.LoadScene("mainScene");

    }
}
