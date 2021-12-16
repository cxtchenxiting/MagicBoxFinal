using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager1 : MonoBehaviour
{
    [HideInInspector]
    public static Manager1 Instance { get; private set; } //used for singleton, can be referenced by any other script

    public GameObject FactoryPrefab;
    public string TargetTag = "Target";
    public string FactoryTag = "Factory";
    public string AgentTag = "Agent";

    private void Awake()
    {
        if (Instance != null && Instance != this) //singleton pattern
            Destroy(this.gameObject);
        else
            Instance = this;
    }

    private GameObject[] _targets;
    private List<GameObject> _occupiedTargets = new List<GameObject>();

    // Start is called before the first frame update
    private void Start()
    {
        _targets = GameObject.FindGameObjectsWithTag(TargetTag);
        int factoryCount = (int)(_targets.Length * 0.5f);
        for (int i = 0; i < factoryCount; i++)
        {
            GameObject target = GetTarget();
            InstantiateFactory(target);
        }
    }

    public GameObject GetTarget()
    {
        int targetIndex = Random.Range(0, _targets.Length);
        GameObject target = _targets[targetIndex];

        int startIndex = targetIndex; //used to test if the index wraps back on itself
        while (_occupiedTargets.Contains(target))
        {
            targetIndex++;
            if (targetIndex >= _targets.Length) { targetIndex = 0; } //loop back to array start
            target = _targets[targetIndex];
            if (startIndex == targetIndex) { break; } //this means indices wrapped
        }
        return target;
    }

    public void InstantiateFactory(GameObject target)
    {
        GameObject go = Instantiate(FactoryPrefab, target.transform.position, target.transform.rotation);
        float moveY = go.transform.localScale.y / 2.0f; //get half factory height
        go.transform.position += new Vector3(0, moveY, 0); //move factory up
        Factory1 factory = go.GetComponent<Factory1>();
        factory.Target = target;
        _occupiedTargets.Add(target); //add to list so this target isn't used anymore
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void RemoveTargetFromList(GameObject target)
    {
        _occupiedTargets.Remove(target);
    }

    public bool IsTargetOccupied(GameObject target)
    {
        return _occupiedTargets.Contains(target);
    }
}