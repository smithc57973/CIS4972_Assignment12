using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Composite : Component
{
    public List<Component> components = new List<Component>();

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

    public override Component GetChild(int i)
    {
        return components[i];
    }
    public override void Add(Component component)
    {
        components.Add(component);
    }
    public override void Remove(Component component)
    {
        components.Remove(component);
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
