using UnityEngine;
public abstract class Effect : ScriptableObject
{
    public abstract void WhenChant(GameObject target);

    public virtual void Update()
    {
    }
   
}
