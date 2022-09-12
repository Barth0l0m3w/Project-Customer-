using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrueChecking : MonoBehaviour
{
    public Pipes[] pipes;
    public string sceneName;

    public void CheckState()
    {
        if (GetComponentsInChildren<Pipes>().All(p => p.isCorrectlyTurned))
        {
            Debug.Log("you've won brug");

            SceneManager.LoadScene(sceneName);
        }
    } 
}