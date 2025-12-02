using UnityEngine;

public class Animal : MonoBehaviour
{
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


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
