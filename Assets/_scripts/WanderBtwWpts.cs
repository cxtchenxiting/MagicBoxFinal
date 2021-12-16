using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WanderBtwWpts : MonoBehaviour
{
    public List<GameObject> wpts;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    private void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        int d = Random.Range(0, wpts.Count);
        if (wpts.Count > d)
            agent.SetDestination(wpts[d].transform.position);
    }

    // Update is called once per frame
    private void Update()
    {
        if (agent.remainingDistance < 0.5)
        {
            //go somewhere else random
            int d = Random.Range(0, wpts.Count);
            if (wpts.Count > d)
                agent.SetDestination(wpts[d].transform.position);
        }
    }
}