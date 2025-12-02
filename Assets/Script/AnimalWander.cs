using UnityEngine;
using UnityEngine.AI;

public class AnimalWander : MonoBehaviour
{
    public float wanderRadius = 10f;
    public float waitTime = 3f;

    NavMeshAgent agent;
    Animator animator;
    float timer;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        timer = waitTime;
    }

    void Update()
    {
        timer += Time.deltaTime;

        bool isMoving = agent.velocity.magnitude > 0.1f;
        animator.SetBool("isWalking", isMoving);
        animator.SetFloat("Speed", agent.velocity.magnitude);

        if (timer >= waitTime)
        {
            Vector3 newPos = RandomNavSphere(transform.position, wanderRadius);
            agent.SetDestination(newPos);
            timer = 0;
        }
    }

    public static Vector3 RandomNavSphere(Vector3 origin, float dist)
    {
        Vector3 randDir = Random.insideUnitSphere * dist;
        randDir += origin;

        NavMeshHit hit;
        NavMesh.SamplePosition(randDir, out hit, dist, NavMesh.AllAreas);

        return hit.position;
    }
}
