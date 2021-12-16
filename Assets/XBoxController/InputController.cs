using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputController : MonoBehaviour
{
    private GameControllerInputs controllerInput;
    public Automate _automate;
    public Transform _target;
    public SolveTwoPhase _solve;
    // Use this for initialization
    void Start()
    {
        controllerInput = GameControllerInputs.GetIstance();
    }
    const float SpaceTime = .5f;
    float _tickTime = 0;
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    _target.transform.Rotate(90, 0, 0, Space.World);
        //}
        //if (Input.GetKeyDown(KeyCode.B))
        //{
        //    _target.transform.Rotate(0, 0, -90, Space.World);
        //}
        //if (Input.GetKeyDown(KeyCode.C))
        //{
        //    _target.transform.Rotate(0, 0, 90, Space.World);
        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    _target.transform.Rotate(-90, 0, 0, Space.World);
        //}
        _tickTime -= Time.deltaTime;
        if (_tickTime <= 0)
        {
            if (GoRight())
            {
                _automate.DoMove("D'");
                _tickTime = SpaceTime;
            }
            else if (GoLeftDirectionalRight())
            {
                _automate.DoMove("D");
                _tickTime = SpaceTime;
            }
            else
           if (GoLeft())
            {
                _automate.DoMove("R'");
                _tickTime = SpaceTime;
            }
            else
           if (GoLeftDirectionalLeft())
            {
                _automate.DoMove("R");
                _tickTime = SpaceTime;
            }
            else
           if (GoUp())
            {
                _automate.DoMove("U");
                _tickTime = SpaceTime;
            }
            else
           if (GoLeftDirectionalUp())
            {
                _automate.DoMove("U'");
                _tickTime = SpaceTime;
            }
            else
           if (GoDown())
            {
                _automate.DoMove("L'");
                _tickTime = SpaceTime;
            }
            else
           if (GoLeftDirectional_Down())
            {
                _automate.DoMove("L'");
                _tickTime = SpaceTime;
            }
            else
           if (GoLeftTriggerButton())
            {
                _automate.DoMove("F'");
                _tickTime = SpaceTime;
            }
            else
           if (GoRightTriggerButton())
            {
                _automate.DoMove("F");
                _tickTime = SpaceTime;
            }
            else if (GoRightDirectionalLeft())
            {
                _target.transform.Rotate(0, 90, 0, Space.World);
                _tickTime = SpaceTime;
            }
            else if (GoRightDirectionalRight())
            {
                _target.transform.Rotate(0, -90, 0, Space.World);
                _tickTime = SpaceTime;
            }
            else if (GoRightDirectionalUp())
            {
                _target.transform.Rotate(90, 0, 0, Space.World);
                _tickTime = SpaceTime;
            }
            else if (GoRightDirectionalDown())
            {
                _target.transform.Rotate(0, 0, -90, Space.World);
                _tickTime = SpaceTime;
            }
            else if (GoButtonA())
            {
                _solve.Solver();
                _tickTime = SpaceTime;
            }
            else if (GoButtonB())
            {
                _automate.Shuffle();
                _tickTime = SpaceTime;
            }
            else if (GoButtonX())
            {
                SceneManager.LoadScene(2);
                _tickTime = SpaceTime;
            }
            else if (GoButtonY())
            {
                SceneManager.LoadScene(3);
                _tickTime = SpaceTime;
            }
            else if (GotoBack())
            {
                Application.Quit();
                _tickTime = SpaceTime;
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#endif
            }
        }
    }
    public bool GoRight()
    {
        if (controllerInput.DPad_Right || Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Right");
            return true;
        }
        else
            return false;
    }
    public bool GoLeftDirectionalRight()
    {
        if (controllerInput.LeftDirectional_asRightButton)
        {
            Debug.Log("LeftDirectional Right");
            return true;
        }
        return false;
    }
    public bool GoLeftTriggerButton()
    {
        if (controllerInput.LeftTrigger_asButton)
        {
            Debug.LogError("left trigger");
            return true;
        }
        return false;
    }
    public bool GoRightTriggerButton()
    {
        if (controllerInput.RightTrigger_asButton)
        {
            Debug.LogError("right trigger");
            return true;
        }
        return false;
    }

    //Get Input to Go Left and Right at a variable speed depending on the directional stick movement.
    public float GoHorizontalAnalog()
    {
        return controllerInput.LeftDirectional_Horizontal;
    }

    //Get Input to Go Left at a fixed speed.
    public bool GoLeft()
    {
        if (controllerInput.DPad_Left || Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Left");
            return true;
        }
        else
            return false;
    }
    public bool GoLeftDirectionalLeft()
    {
        if (controllerInput.LeftDirectional_asLeftButton)
        {
            Debug.Log("LeftDirectional Left");
            return true;
        }
        return false;
    }

    //Get Input to Go Up at a fixed speed.
    public bool GoUp()
    {
        if (controllerInput.DPad_Up || Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Up");
            return true;
        }
        else
            return false;
    }
    public bool GoLeftDirectionalUp()
    {
        if (controllerInput.LeftDirectional_asUpButton)
        {
            Debug.Log("LeftDirect Up");
            return true;
        }
        return false;
    }

    // Get Input to Go Down at a fixed speed.
    public bool GoDown()
    {
        if (controllerInput.DPad_Down || Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Down");
            return true;
        }
        else
            return false;
    }
    public bool GoLeftDirectional_Down()
    {
        if (controllerInput.LeftDirectional_asDownButton)
        {
            Debug.Log("LeftDirectinal Down");
            return true;
        }
        return false;
    }
    public bool GoRightDirectionalLeft()
    {
        if (controllerInput.RightDirectional_asLeftButton)
        {
            Debug.Log("RightDirectional Left");
            return true;
        }
        return false;
    }
    public bool GoRightDirectionalRight()
    {
        if (controllerInput.RightDirectional_asRightButton)
        {
            Debug.Log("RightDirectional Right");
            return true;
        }
        return false;
    }
    public bool GoRightDirectionalUp()
    {
        if (controllerInput.RightDirectional_asUpButton)
        {
            Debug.Log("RightDirectional Up");
            return true;
        }
        return false;
    }
    public bool GoRightDirectionalDown()
    {
        if (controllerInput.RightDirectional_asDownButton)
        {
            Debug.Log("RightDirectional Down");
            return true;
        }
        return false;
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
    public bool GoButtonX()
    {
        if (controllerInput.X_button_down)
        {
            return true;
        }
        return false;
    }
    public bool GoButtonY()
    {
        if (controllerInput.Y_button_down)
        {
            return true;
        }
        return false;
    }
    public bool GotoBack()
    {
        if (controllerInput.Back_down)
        {
            return true;
        }
        return false;
    }
    // Get Input toJump (Only used by the Alien)
    public bool JumpNow()
    {
        if (controllerInput.A_button_down || Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump");
            return true;
        }
        else
            return false;
    }

    //Get Input to Attack (Only used by the Alien)
    public bool AttackNow()
    {
        if (controllerInput.X_button_down || Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("attack");
            return true;
        }
        else
            return false;
    }

    //Not used
    public bool DuckNow()
    {
        return false;
    }

    //Get input to set the Alien as the active character.
    public bool ChangeToAlien()
    {
        if (controllerInput.LB_down || Input.GetKeyDown(KeyCode.Alpha1))
            return true;
        else
            return false;

    }

    //Get input to set the Ship as the active character.
    public bool ChangeToShip()
    {
        if (controllerInput.RB_down || Input.GetKeyDown(KeyCode.Alpha2))
            return true;
        else
            return false;
    }

    //Get Input (press button down) to Shoot a coin downwards (Only used by the Ship)
    public bool ShootCoinDown()
    {
        if (controllerInput.RightDir_press_down || Input.GetKeyDown(KeyCode.Space))
            return true;
        else
            return false;
    }

    //Get Input (release button) to Shoot a coin upwards (Only used by the Ship)
    public bool ShootCoinUp()
    {
        if (controllerInput.RightDir_press_up || Input.GetKeyUp(KeyCode.Space))
            return true;
        else
            return false;
    }
}
