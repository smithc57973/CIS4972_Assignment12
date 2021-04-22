using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Component : MonoBehaviour
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

    public abstract Shape GetShape();
    public abstract GameObject GetPrefab();
    //public abstract void Draw(Shape s, Color c);
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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
