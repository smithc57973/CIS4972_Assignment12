using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaf : Component
{
    /*public override void Draw(Shape s, Color c)
    {
        Instantiate(GetPrefab());
    }*/

    public override void Rotate()
    {
        throw new System.NotImplementedException();
    }

    public override GameObject GetPrefab()
    {
        return prefab;
    }

    public override Shape GetShape()
    {
        return shape;
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
