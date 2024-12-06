using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{
    private int totalTargets; 
    private int destroyedTargets = 0;
    public Canvas winMessage;

    public static bool hasWon = false;

    void Start()
    {
        totalTargets = 5;
    }

    public void TargetDestroyed()
    {
        destroyedTargets++;

        if (destroyedTargets >= totalTargets)
        {
            TriggerWinCondition();
        }
    }

    private void TriggerWinCondition()
    {
        hasWon = true;

        if (winMessage != null)
        {
            winMessage.gameObject.SetActive(true); 
        }


    }
}
