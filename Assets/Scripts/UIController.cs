using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    Text hpValue;
    PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        hpValue = transform.GetChild(1).GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        hpValue.text = player.GetHp().ToString();
    }
}
