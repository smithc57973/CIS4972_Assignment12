/*
 * Chris Smith
 * MyComponent
 * Assignment 12
 * An abstract class defining a component and its methods.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MyComponent : MonoBehaviour
{
    public abstract void Rotate();

    public virtual MyComponent GetChild(int i)
    {
        throw new System.NotSupportedException("GetChildItem() is not supported for " + this.GetType().Name);
    }
    public virtual void Add(MyComponent component)
    {
        throw new System.NotSupportedException("Add() is not supported for " + this.GetType().Name);
    }
    public virtual void Remove(MyComponent component)
    {
        throw new System.NotSupportedException("Remove() is not supported for " + this.GetType().Name);
    }
}
