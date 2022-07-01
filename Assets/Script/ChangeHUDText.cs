using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ChangeHUDText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI hudText;
    void Update()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            hudText.SetText("Press E to change scene (Day)");
        }
        if (currentSceneIndex == 1)
        {
            hudText.SetText("Press E to change scene (Night)");
        }
        else
        {
            return;
        }
    }
}
