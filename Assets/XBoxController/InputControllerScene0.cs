using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputControllerScene0 : MonoBehaviour
{
    private GameControllerInputs controllerInput;
    // Use this for initialization
    void Start()
    {
        controllerInput = GameControllerInputs.GetIstance();
    }
    const float SpaceTime = .5f;
    float _tickTime = 0;
    private void Update()
    {
        _tickTime -= Time.deltaTime;
        if (GoButtonA())
        {
            SceneManager.LoadScene(1);
            _tickTime = SpaceTime;
        }
        else if (GoButtonB())
        {
            SceneManager.LoadScene(3);
            _tickTime = SpaceTime;
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
    public bool GoButtonB()
    {
        if (controllerInput.B_button_down)
        {
            return true;
        }
        return false;
    }
}
