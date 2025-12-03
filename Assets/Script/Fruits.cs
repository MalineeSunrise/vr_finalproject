using UnityEngine;

public class Fruits : MonoBehaviour
{
    public Animal animal;

    public void addHunger(float value)
    {
        animal.CurrentHunger += value;
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
