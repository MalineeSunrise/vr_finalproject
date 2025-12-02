using System.Collections;
using UnityEngine;

public class AnimalEatTrigger : MonoBehaviour
{
    public Animator animator;
    public UnityEngine.AI.NavMeshAgent agent;
    public float eatDuration = 4f;

    bool isEating = false;

    private void OnTriggerEnter(Collider other)
    {
        if (isEating) return;

        if (other.CompareTag("Fruits"))
        {
            StartCoroutine(Eat(other.gameObject));
        }
    }

    IEnumerator Eat(GameObject fruits)
    {
        isEating = true;

        // ????????
        if (agent != null) agent.isStopped = true;

        // ??????????????????
        Vector3 lookPoint = fruits.transform.position;
        lookPoint.y = transform.position.y;
        transform.LookAt(lookPoint);

        animator.SetBool("isWalking", false);
        animator.SetBool("isEating", true);

        yield return new WaitForSeconds(eatDuration);

        animator.SetBool("isEating", false);

        Destroy(fruits); // ??????????

        if (agent != null) agent.isStopped = false;

        isEating = false;
    }
}