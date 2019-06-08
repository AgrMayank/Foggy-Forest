using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAnimController : MonoBehaviour
{

	private Animator anim;
	public NavMeshAgent navMeshAgent;
	public bool isWalking;

    // Start is called before the first frame update
    void Start()
    {
		anim = GetComponent<Animator> ();
		navMeshAgent = GetComponent<NavMeshAgent> ();
    }

    // Update is called once per frame
    void Update()
    {
		/*
		if (navMeshAgent.velocity != Vector3.zero)
		{
			isWalking = true;
		}
		else
		{
			isWalking = false;
		}

		anim.SetBool ("IsWalking", isWalking);
		*/

		anim.SetFloat ("PlayerVel", navMeshAgent.velocity.magnitude);

		print (navMeshAgent.velocity.magnitude);
    }
}
