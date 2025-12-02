using UnityEngine;

public class Animal : MonoBehaviour
{
    public Animator playerAnimator;
    public float MaxHunger = 100;

    public float CurrentHunger = 50;

    public void addHunger(float hunger)
    {
        CurrentHunger += hunger;
    }

    public Animator animator;
    public void PlayEatAnimation()
    {
        animator.SetTrigger("Zebra Eat"); 
    }

    private const string EAT_TRIGGER_NAME = "Eat";
    public void TriggerEatingAnimation()
    {
        if (playerAnimator != null)
        {
            // ??????????? Animator ??????????????? "Eat" ???
            playerAnimator.SetTrigger(EAT_TRIGGER_NAME);
        }
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
