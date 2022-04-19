using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillHolder : MonoBehaviour
{
    public SkillObject skill;

    [SerializeField] string skillKey;
    float activeTime;
    float cooldownTime;

    enum SkillState
    {
        Ready,
        Active,
        Cooldown
    }

    SkillState state = SkillState.Ready;

    // Update is called once per frame
    void Update()
    {
        switch(state)
        {
            case SkillState.Ready:
                if(Input.GetButtonDown(skillKey))
                {
                    skill.Activate(gameObject);
                    state = SkillState.Active;
                    activeTime = skill.GetActiveTime();
                }
                break;
            case SkillState.Active:
                if(activeTime > 0.0f)
                {
                    activeTime -= Time.deltaTime;
                }
                else
                {
                    state = SkillState.Cooldown;
                    cooldownTime = skill.GetCdTime();
                }
                break;
            case SkillState.Cooldown:
                if (cooldownTime > 0.0f)
                {
                    cooldownTime -= Time.deltaTime;
                }
                else
                {
                    state = SkillState.Ready;
                }
                break;
        }
    }
}
