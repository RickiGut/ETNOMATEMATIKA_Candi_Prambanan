using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    public void ChangeSceneWithDelay(string sceneName)
    {
        audioManager.PlaySFX(audioManager.click);
        StartCoroutine(WaitAndChangeScene(sceneName, 0.3f));
    }

    IEnumerator WaitAndChangeScene(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
        ResetPlayerPrefs();
    }

    void ResetPlayerPrefs()
    {
        PlayerPrefs.DeleteKey("score");

        PlayerPrefs.Save();
    }

    public void CloseApp()
    {
        Application.Quit();
    }
}
