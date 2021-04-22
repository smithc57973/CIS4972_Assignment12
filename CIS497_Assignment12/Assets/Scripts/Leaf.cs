/*
 * Chris Smith
 * Leaf
 * Assignment 12
 * A class defining a leaf component and its methods.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaf : MyComponent
{
    public enum Shape
    {
        Empty,
        Square,
        Hexagon,
        Diamond,
    }
    public Shape shape;
    public Color color;
    public GameObject prefab;

    public override void Rotate()
    {
        StartCoroutine(Spin());
    }

    public IEnumerator Spin()
    {
        this.gameObject.transform.Rotate(0.0f, 0.0f, 30.0f);
        yield return new WaitForSeconds(.5f);
        this.gameObject.transform.Rotate(0.0f, 0.0f, 30.0f);
        yield return new WaitForSeconds(.5f);
        this.gameObject.transform.Rotate(0.0f, 0.0f, 30.0f);
        yield return new WaitForSeconds(.5f);
    }
}
