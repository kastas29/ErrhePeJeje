using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TingController : MonoBehaviour
{

    NavMeshAgent nmAgent;
    public List<GameObject> Targets;

    void Start()
    {
        nmAgent = GetComponent<NavMeshAgent>();

        StartCoroutine(GoNextTarget());
    }

    IEnumerator GoNextTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            print("new target");
            int newTargetIndex = Random.Range(0, Targets.Count - 1);
            GameObject newTarget = Targets[newTargetIndex];
            nmAgent.destination = newTarget.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
