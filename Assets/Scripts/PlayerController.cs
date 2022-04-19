using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Camera mainCam;
    public Vector3 move;
    [SerializeField] float moveSpeed;
    [SerializeField] int hp;

    public InventoryObject inventory;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
        if(!inventory)
        {
            inventory = new InventoryObject();
        }
    }

    // Update is called once per frame
    void Update()
    {

        //Player Actions
        if(Input.GetButtonDown("Fire1"))
        {
            Debug.Log("ClicGauche");
        }
        if (Input.GetButtonDown("Fire2"))
        {
            Debug.Log("ClicDroit");
        }
        if(Input.GetButtonDown("Interact"))
        {
            Debug.Log("Interact");
        }

        /*if(Input.GetButtonDown("Skill1"))
        {
            Debug.Log("Skill1");
        }
        if (Input.GetButtonDown("Skill2"))
        {
            Debug.Log("Skill2");
        }
        if (Input.GetButtonDown("Skill3"))
        {
            Debug.Log("Skill3");
        }
        if (Input.GetButtonDown("Skill4"))
        {
            Debug.Log("Skill4");
        }*/


        if (Input.GetAxisRaw("Horizontal")==0 && Input.GetAxisRaw("Vertical") == 0)
        {
            move = Vector3.zero;
        }

        move =  Input.GetAxis("Vertical")*transform.forward + Input.GetAxis("Horizontal")*transform.right;
        move.Normalize();

        transform.Translate(move * moveSpeed * Time.deltaTime);
       
    }

    public void OnTriggerEnter(Collider other)
    {
        var item = other.GetComponent<Item>();
        if(item)
        {
            inventory.AddItem(item.item, 1);
            Destroy(other.gameObject);
        }
    }

    public int GetHp()
    {
        return hp;
    }
}
