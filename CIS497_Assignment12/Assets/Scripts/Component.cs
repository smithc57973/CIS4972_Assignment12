using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Component : MonoBehaviour
{
    public abstract void Rotate();

    public virtual Component GetChild(int i)
    {
        throw new System.NotSupportedException("GetChildItem() is not supported for " + this.GetType().Name);
    }
    public virtual void Add(Component component)
    {
        throw new System.NotSupportedException("Add() is not supported for " + this.GetType().Name);
    }
    public virtual void Remove(Component component)
    {
        throw new System.NotSupportedException("Remove() is not supported for " + this.GetType().Name);
    }
}
