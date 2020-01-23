using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public Transform TargetObject;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TargetObject != null)
        {
            GetComponent<NavMeshAgent>().destination = TargetObject.position;
        }
    }
}