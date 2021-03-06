using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// INHERITANCE
// Parent class
public abstract class Vehicle : MonoBehaviour
{
    protected Text messageText;
    protected Renderer markRenderer;

    // read-only properties
    public string Color { get; protected set; }
    public float Weight { get; protected set; }
    public float MaxSpeed { get; protected set; }

    void Start()
    {
        Init();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;
                if(hitObject.tag == "Vehicle")
                {
                    // display mark and change mark position
                    markRenderer.enabled = true;
                    markRenderer.transform.position = hitObject.transform.position + new Vector3(0, 5, 0);
                    var vehicle = hitObject.GetComponent<Vehicle>();

                    messageText.text = $"{hitObject.name} Says: {vehicle.ShowYourself()}";
                }
                else
                {
                    // if don't click on vehicles, hide mark and clear messageText
                    markRenderer.enabled = false;
                    messageText.text = "";
                }
            }
        }
    }

    // POLYMORPHISM - overloading
    protected void Init()
    {
        this.Init("Black", 2000, 100);
    }

    protected void Init(string color, float weight, float maxSpeed)
    {
        Color = color;
        Weight = weight;
        MaxSpeed = maxSpeed;

        messageText ??= GameObject.Find("Text").GetComponent<Text>();
        markRenderer ??= GameObject.Find("Mark").GetComponent<Renderer>();

        // hide mark initially
        markRenderer.enabled = false;
    }

    public virtual string Move()
    {
        return $"{gameObject.name} is moving...";
    }

    public virtual string Honk()
    {
        return $"{gameObject.name} is honking...";
    }

    public virtual string Description()
    {
        return $"I am {Color} and {Weight} KGs, and my max speed is {MaxSpeed} KM/h.";
    }

    public abstract string ShowYourself();
}
