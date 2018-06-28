using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private bool gotStrawberries;
    private bool gotSugar;
    private bool gotFlour;
    private bool gotButter;

    // Use this for initialization
    void Start()
    {
        gotStrawberries = false;
        gotSugar = false;
        gotFlour = false;
        gotButter = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        //Debug.Log(col.gameObject.name);
        if (col.gameObject.name == "Strawberry1")
        {
            gotStrawberries = true;
            //col.gameObject.SetActive(false);
        }

        if (col.gameObject.name == "Strawberry2")
        {
            gotStrawberries = true;
            //col.gameObject.SetActive(false);
        }

        if (col.gameObject.name == "Strawberry3")
        {
            gotStrawberries = true;
            //col.gameObject.SetActive(false);
        }

        if (col.gameObject.name == "Strawberry4")
        {
            gotStrawberries = true;
            //col.gameObject.SetActive(false);
        }

        if (col.gameObject.name == "Sugar")
        {
            gotSugar = true;
            //col.gameObject.SetActive(false);
        }
        if (col.gameObject.name == "Flour")
        {
            gotFlour = true;
            //col.gameObject.SetActive(false);
        }
        if (col.gameObject.name == "Butter1")
        {
            gotButter = true;
            //col.gameObject.SetActive(false);
        }

        if (col.gameObject.name == "Butter2")
        {
            gotButter = true;
            //col.gameObject.SetActive(false);
        }

        if (col.gameObject.name == "Butter3")
        {
            gotButter = true;
            //col.gameObject.SetActive(false);
        }
        if (gotStrawberries && gotSugar && gotFlour && gotButter)
        {
            GameObject.Find("Strawberry1").SetActive(false);
            GameObject.Find("Strawberry2").SetActive(false);
            GameObject.Find("Strawberry3").SetActive(false);
            GameObject.Find("Strawberry4").SetActive(false);
            GameObject.Find("Sugar").SetActive(false);
            GameObject.Find("Flour").SetActive(false);
            GameObject.Find("Butter1").SetActive(false);
            GameObject.Find("Butter2").SetActive(false);
            GameObject.Find("Butter3").SetActive(false);
            GameObject.Find("Cake").GetComponent<MeshRenderer>().enabled = true;
        }
    }
}