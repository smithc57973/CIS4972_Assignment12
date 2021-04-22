using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Composite : Component
{
    public List<Component> components = new List<Component>();

    public override void Rotate()
    {
        IterateWithIEnumerator(components);
    }

    private void IterateWithIEnumerator(IEnumerable<Component> components)
    {
        //Get the Enumerator
        IEnumerator<Component> enumerator = components.GetEnumerator();

        //Enumerator starts at index -1
        //while there's still a next item, go to the next position
        while (enumerator.MoveNext())
        {
            //get the current componenet the enumerator is pointing to
            Component component = enumerator.Current;

            //call print on that component
            component.Rotate();
        }

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
