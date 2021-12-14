using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputControllerScene3 : MonoBehaviour
{
    private GameControllerInputs controllerInput;
    public CamCtrl _camCtr;
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
        if (_tickTime <= 0)
        {
            if (GoBack())
            {
                Application.Quit();
                _tickTime = SpaceTime;
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#endif
            }
        }
        if (GoLeft())
        {
            _camCtr.Call(new Vector3(-10, 0));
        }
        else if (GoRight())
        {
            _camCtr.Call(new Vector3(10, 0));
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
    public bool GoLeft()
    {
        if (controllerInput.RightDirectional_asLeftButton)
        {
            return true;
        }
        return false;
    }
    public bool GoRight()
    {
        if (controllerInput.RightDirectional_asRightButton)
        {
            return true;
        }
        return false;
    }
}
