using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CameraManager : MonoBehaviour {
    public int CurrentCamera;
    public GameObject[] cameraObject;

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            CurrentCamera += 1;
            if(CurrentCamera > 2)
            {
                CurrentCamera = 0;
            }

            SwitchCamera();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CurrentCamera -= 1;
            if (CurrentCamera < 0)
            {
                CurrentCamera = 2;
            }

            SwitchCamera();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ResetLevel();
        }

    }

    void SwitchCamera()
    {
        for (int i = 0; i < cameraObject.Length; i++)
        {
            if(i == CurrentCamera)
            {
                cameraObject[CurrentCamera].gameObject.SetActive(true);
            }

            else
            {
                cameraObject[i].gameObject.SetActive(false);
            }
        }
    }

    void ResetLevel()
    {
        SceneManager.LoadScene(0);
    }
}
