using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class EventTrigger : MonoBehaviour
{
    public UnityEvent onTrigger;

    public GameObject gamgObject;

    public bool destroyAfterTrigger = true;

    private void Awake()
    {
        if (onTrigger == null)
        {
            onTrigger = new UnityEvent();
        }

        void onTriggerEnter(Collider other)
        {
            onTrigger.Invoke();
            if (destroyAfterTrigger)
            {
                Destroy(gameObject);
            }
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}