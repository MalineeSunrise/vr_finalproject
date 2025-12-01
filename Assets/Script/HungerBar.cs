using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;
public class HungerBar : MonoBehaviour
{
    public Animal hunger;
    public Slider hungerFill;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hungerFill.value = hunger.CurrentHunger / hunger.MaxHunger;
    }
}
