using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationPNJ : MonoBehaviour
{
    public float minWaitTime = 2f; // Temps minimum d'attente avant de choisir un nouveau point
    public float maxWaitTime = 5f; // Temps maximum d'attente avant de choisir un nouveau point
    public float radius = 50f;     // Rayon autour de l'agent pour générer des points aléatoires

    private NavMeshAgent agent;
    private Vector3 destination;
    private bool destinationReached = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(MoveToRandomPoints());
    }

    IEnumerator MoveToRandomPoints()
    {
        while (true)
        {
            // Si l'agent a atteint sa destination ou n'a pas encore de destination
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
            {
                destinationReached = true;
            }

            // Si la destination est atteinte, attendre un peu puis choisir un nouveau point
            if (destinationReached)
            {
                destinationReached = false;
                float waitTime = Random.Range(minWaitTime, maxWaitTime);
                yield return new WaitForSeconds(waitTime);
                SetRandomDestination();
            }

            yield return null;
        }
    }

    void SetRandomDestination()
    {
        Vector3 randomDirection = Random.insideUnitSphere * radius;
        randomDirection += transform.position;

        NavMeshHit hit;
        if (NavMesh.SamplePosition(randomDirection, out hit, radius, 1))
        {
            destination = hit.position;
            agent.SetDestination(destination);
        }
    }
}
