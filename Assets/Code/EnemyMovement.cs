using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }
    private void Update()
    {
        Vector2 input = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        agent.SetDestination(input);

        if (agent.remainingDistance < 1)
        {
            print("llego al objetivo");
        }
    }
}