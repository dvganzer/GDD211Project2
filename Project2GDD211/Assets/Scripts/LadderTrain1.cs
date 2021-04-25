using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LadderTrain1 : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene(2);
        }
    }
}
