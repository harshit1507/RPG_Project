using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField] Transform target;

    // Start is called before the first frame update
    void Start()
    {
       // NavMeshAgent agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            MoveToCursor();
        }

        //Debug.DrawRay(lastRay.origin, lastRay.direction * 100);
        
        
    }

    private void MoveToCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            GetComponent<NavMeshAgent>().SetDestination(hit.point);
        }
        
        
    }
}
