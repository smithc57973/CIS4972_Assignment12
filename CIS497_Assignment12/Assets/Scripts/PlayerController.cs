using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Composite canvas;
    public Leaf.Shape currentShape;
    public Color currentColor;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentShape = Leaf.Shape.Square;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentShape = Leaf.Shape.Circle;
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
        }

        if (Input.GetMouseButtonDown(0))
        {
            canvas.Rotate();
        }
        if (Input.GetMouseButtonDown(1))
        {
            canvas.components[0].Rotate();
        }
    }
}
