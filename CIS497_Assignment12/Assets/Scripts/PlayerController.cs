/*
 * Chris Smith
 * PlayerController
 * Assignment 12
 * A script for managing player inputs.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Composite overall;
    //public Composite within;
    public MyComponent currentC;
    public int index;
    //public Leaf.Shape currentShape;
    //public Color currentColor;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        currentC = overall.components[0];
        //currentShape = Leaf.Shape.Square;
        //currentColor = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
         /*if (Input.GetKeyDown(KeyCode.Space))
        {
            Draw(currentShape, currentColor, currentC);
        }
         
          if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentShape = Leaf.Shape.Square;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentShape = Leaf.Shape.Hexagon;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentShape = Leaf.Shape.Diamond;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentColor = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            currentColor = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            currentColor = Color.blue;
        }*/

        /*if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            if (currentC == overall)
            {
                currentC = within;
            }
            else if (currentC == within)
            {
                currentC = overall;
            }
        }*/

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            overall.Rotate();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentC.Rotate();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (index < overall.components.Count - 1)
            {
                index++;
            }
            else
            {
                index = 0;
            }
            currentC = overall.components[index];
            text.text = "Current Container: " + currentC.ToString();
        }
    }

    /*public void Draw(Leaf.Shape shape, Color color, Composite com)
    {
        GameObject l = (GameObject)Resources.Load(shape.ToString());
        l.GetComponent<SpriteRenderer>().color = color;
        com.Add(Instantiate(l.GetComponent<Leaf>(), com.transform, false));

    }*/
}
