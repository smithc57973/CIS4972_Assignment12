/*
 * Chris Smith
 * Composite
 * Assignment 12
 * A class defining a composite component and its methods.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Composite : MyComponent
{
    public List<MyComponent> components = new List<MyComponent>();

    public override void Rotate()
    {
        IterateWithIEnumerator(components);
    }

    private void IterateWithIEnumerator(IEnumerable<MyComponent> components)
    {
        //Get the Enumerator
        IEnumerator<MyComponent> enumerator = components.GetEnumerator();

        //Enumerator starts at index -1
        //while there's still a next item, go to the next position
        while (enumerator.MoveNext())
        {
            //get the current componenet the enumerator is pointing to
            MyComponent component = enumerator.Current;

            //call print on that component
            component.Rotate();
        }

    }

    public override MyComponent GetChild(int i)
    {
        return components[i];
    }
    public override void Add(MyComponent component)
    {
        components.Add(component);
    }
    public override void Remove(MyComponent component)
    {
        components.Remove(component);
    }
}
