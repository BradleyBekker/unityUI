using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bar2 : MonoBehaviour {

    private float fillContent;
    public float Value = 100;




    [SerializeField]
    private Image content;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    private void Handlebar()
    {



    }



    private float Map(float value, float inMin, float inMax, float outMin, float outMax)
    {
        return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
    }


    public void buttonadd()
    {
        if (Value != 100)
        {
            Value += 10;
            content.fillAmount = Map(Value, 0, 100, 0, 1);
        }
    }
    public void buttonremove()
    {
        if (Value != 0)
        {
            Value -= 10;
            content.fillAmount = Map(Value, 0, 100, 0, 1);
        }
    }
}