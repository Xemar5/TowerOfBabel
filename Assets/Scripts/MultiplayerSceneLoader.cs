using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MultiplayerSceneLoader : MonoBehaviour
{
    [SerializeField]
    private CanvasGroup gameplayGroup;
    [SerializeField]
    private CanvasGroup winnerGroup;
    [SerializeField]
    private TMP_Text winnerText;


    private Coroutine showCoroutine;
    private Inputs inputs;
    private Scene currentScene;
    private bool gameEnded = false;

    private void Awake()
    {
        inputs = new Inputs();
        inputs.Gameplay.Restart.performed += Restart_performed;
        inputs.Gameplay.Enable();
        currentScene = SceneManager.GetActiveScene();
        winnerGroup.alpha = 0;
        gameplayGroup.alpha = 1;
        StartGame();

        MultiplayerInitializer.OnEnd += (_, winners) => showCoroutine = StartCoroutine(ShowWinGui(winners));
    }

    private IEnumerator ShowWinGui(PlayerColor winners)
    {
        if (gameEnded == true)
        {
            showCoroutine = null;
            yield break;
        }
        gameEnded = true;

        string winnerMessage = "Winners" + Environment.NewLine;
        if (winners.HasFlag(PlayerColor.Red)) winnerMessage += "<color=red>Red</color> & <color=green>Green</color>" + Environment.NewLine + "<color=blue>Blue</color> & <color=yellow>Yellow</color>";
        else winnerMessage += "<color=#853>Brown</color> & <color=orange>Orange</color>" + Environment.NewLine + "<color=#0ff>Teal</color> & <color=purple>Purple</color>";
        winnerText.text = winnerMessage;

        float time = 0;
        while (time < 1)
        {
            time += Time.deltaTime;
            gameplayGroup.alpha = 1 - time;
            winnerGroup.alpha = time;
            yield return null;
        }
        gameplayGroup.alpha = 0;
        winnerGroup.alpha = 1;
        showCoroutine = null;
    }

    private void HideWinGui()
    {
        if (gameEnded == false)
        {
            return;
        }
        gameEnded = false;
        if (showCoroutine != null)
        {
            StopCoroutine(showCoroutine);
            showCoroutine = null;
        }
        gameplayGroup.alpha = 1;
        winnerGroup.alpha = 0;
    }

    private void Restart_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        if (gameEnded == true)
        {
            HideWinGui();
        }
        List<Scene> activeScenes = new List<Scene>();
        for (int i = 0; i < SceneManager.sceneCount; i++)
        {
            Scene scene = SceneManager.GetSceneAt(i);
            if (scene != currentScene)
            {
                activeScenes.Add(scene);
            }
        }
        foreach (Scene activeScene in activeScenes)
        {
            SceneManager.UnloadSceneAsync(activeScene);
        }
        StartGame();
    }

    private void StartGame()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }


}
