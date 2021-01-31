using UnityEngine;
public abstract class Effect : ScriptableObject
{
    public abstract void WhenChant(Target target);

    public virtual void Update()
    {
    }
   
}
