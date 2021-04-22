using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaf : Component
{
    public enum Shape
    {
        Empty,
        Square,
        Circle,
        Diamond,
    }
    public Shape shape;
    public Color color;
    public GameObject prefab;

    public override void Rotate()
    {
        gameObject.transform.Rotate(90.0f, 0.0f, 0.0f);
    }
}
