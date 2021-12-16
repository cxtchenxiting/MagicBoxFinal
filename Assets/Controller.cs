using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public List<Transform> ChangeRenderList = new List<Transform>();
    public CubeState rc;
    private void Start()
    {
        //ChangeMat();
    }
    bool IsChecked = true;
    private void Update()
    {
        if (IsChecked)
        {
            string moveString = rc.GetStateString();
            //Debug.Log(moveString);
            if (moveString == "FUFFUULBULRDLRDBFFDRBLFBUBRBDDDDRDFRLLBLLDFFRRBURBUUUL")
            {
                IsChecked = false;
                ChangeMat();
                Debug.LogError("change color , skil scene");
                StartCoroutine(WaitSkip());
            }
        }
    }
    void ChangeMat()
    {
        for (int i = 0; i < ChangeRenderList.Count; i++)
        {
            var item = ChangeRenderList[i];
            foreach (var it in item.GetComponentsInChildren<MeshRenderer>())
            {
                it.material = Resources.Load<Material>("ChangeMaterial");
            }
        }
    }
    IEnumerator WaitSkip()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("2");//skip scene name 2
    }
}
