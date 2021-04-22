using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Composite canvas;
    public Composite left;
    public Composite right;
    public Component.Shape currentShape;
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
            currentShape = Component.Shape.Square;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentShape = Component.Shape.Circle;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentShape = Component.Shape.Diamond;
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
            //canvas.Draw(currentShape, currentColor);
            Draw(left);
        }
        if (Input.GetMouseButtonDown(0))
        {
            //canvas.Draw(currentShape, currentColor);
            Draw(right);
        }
    }

    public void Draw(Composite c)
    {
        Leaf l = new Leaf();
        l.shape = currentShape;
        l.color = currentColor;
        Instantiate(l.GetPrefab(), c.transform);
        c.Add(l);
    }
}
