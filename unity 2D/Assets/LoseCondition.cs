using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCondition : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(2);
    }

}
