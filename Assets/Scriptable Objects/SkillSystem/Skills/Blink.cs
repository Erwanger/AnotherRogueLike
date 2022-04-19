using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Blink Skill", menuName = "Skill System/Blink")]
public class Blink : SkillObject
{
    [SerializeField] float distance;

    public override void Activate(GameObject parent)
    {
        Debug.Log("Blink");
        parent.transform.Translate(parent.GetComponent<PlayerController>().move * distance);
        
    }
}
