using UnityEngine;

public class Animal : MonoBehaviour
{

    protected float MaxHunger = 100;

    protected float CurrentHunger = 50;

    public void addHunger(int hunger)
    {
        CurrentHunger += hunger;
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
