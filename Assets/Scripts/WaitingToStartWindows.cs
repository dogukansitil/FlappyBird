using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitingToStartWindows : MonoBehaviour
{
    private void Start()
    {
        Bird.GetInstance().OnStartedPlaying += WaitingToStartWindows_OnStartedPlaying;
    }

    private void WaitingToStartWindows_OnStartedPlaying(object sender, System.EventArgs e)
    {
        Hide();
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }
}
