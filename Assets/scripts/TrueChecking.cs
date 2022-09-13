using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrueChecking : MonoBehaviour
{
    private Pipes[] pipes;
    public string sceneName;

    void Update()
    {
        
    }

    public void CheckState()
    {
        if (GetComponentsInChildren<Pipes>().All(p => p.isCorrectlyTurned))
        {
            Debug.Log("you've won brug");

            SceneManager.LoadScene(sceneName);
        }
    } 
}