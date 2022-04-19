using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillObject : ScriptableObject
{
    [SerializeField] new string name;
    [SerializeField] float cdTime;
    [SerializeField] float activeTime;
    [SerializeField] string description;

    public virtual void Activate(GameObject parent) { }
    public virtual void BeginCooldown() { }

    public float GetCdTime()
    {
        return cdTime;
    }

    public float GetActiveTime()
    {
        return activeTime;
    }

    public string GetDescription()
    {
        return description;
    }
}