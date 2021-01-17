using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Follow : MonoBehaviour
{

    public Transform Player;
    public Animator anim;

    int MoveSpeed = 4;
    public int MaxDist;
    public int MinDist;

    void Start()
    {
        Player = GameObject.Find("ARCore Device").gameObject.transform;
        anim = this.gameObject.GetComponent<Animator>();
        anim.SetBool("Attack", false);
        anim.SetBool("Running", false);
    }

    void Update()
    {
        //transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            anim.SetBool("Attack", false);
            anim.SetBool("Running", true);


            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
                anim.SetBool("Running", false);
                anim.SetBool("Attack", true);
            }

        }
    }

    public void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Hit!");
        if (other.CompareTag("Player"))
        {
            Debug.Log("Hit!");
            other.gameObject.GetComponent<Health>().TakeDamage(30);
        }
    }
}