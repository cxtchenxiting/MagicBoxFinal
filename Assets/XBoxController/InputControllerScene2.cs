using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputControllerScene2 : MonoBehaviour
{
    private GameControllerInputs controllerInput;
    // Use this for initialization
    void Start()
    {
        controllerInput = GameControllerInputs.GetIstance();
    }
    const float SpaceTime = 1f;
    float _tickTime = 0;
    private void Update()
    {
        _tickTime -= Time.deltaTime;
        if (_tickTime <= 0)
        {
            if (GoButtonA())
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                _tickTime = SpaceTime;
            }
            else if (GoBack())
            {
                Application.Quit();
                _tickTime = SpaceTime;
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#endif
            }
        }
    }
    public bool GoButtonA()
    {
        if (controllerInput.A_button_down)
        {
            return true;
        }
        return false;
    }
    public bool GoBack()
    {
        if (controllerInput.Back_down)
        {
            return true;
        }
        return false;
    }
}
