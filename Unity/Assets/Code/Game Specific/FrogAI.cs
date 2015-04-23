﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(AIBehaviorController), typeof(PhysicsController), typeof(Animator))]
public class FrogAI : MonoBehaviour 
{
    
    public List<AIBehaviorTrigger> StandardBehaviors;
    // Think about interupting?

    private AIBehaviorController AIController;
    private PhysicsController ph;
    private Animator anim;

    private Coroutine currentRoutine;

	// Use this for initialization
	void Start () 
    {
        AIController = GetComponent<AIBehaviorController>();
        ph = GetComponent<PhysicsController>();
        anim = GetComponent<Animator>();

        for (int i = 0; i < StandardBehaviors.Count; i++)
            AIController.AddBehavior(StandardBehaviors[i].Behavior, true);

        //currentRoutine = StartCoroutine(RandomMoveCR());
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        if(Input.GetKeyUp(KeyCode.I))
        {
            AIController.PrintBehaviors();
        }

        AIController.ClearBehaviors();
	}



    #region Boss Logic

    //private IEnumerator CoreLogicLoop()
    //{
    //    // Core logic
    //    // Action
    //    // Find a new action to do

    //    // Wait
    //    // *Rotate 
    //    // * = optional
    //}

    private void StartFunction(string name)
    {
        switch(name)
        {
            case "Idle":            
            case "Rotate":
            case "FrontHop":
            case "BackHop":
            case "SideHop":
            case "SideSweep":
            case "BacklegSweep":
            case "Tongue":
            case "Secrete":
            default:                break;
        }
    }

    #region Shared Functions

    private void JumpCR()
    {

    }

    private void MoveCR()
    {

    }

    private void RotateCR()
    {

    }

    private IEnumerator RandomMoveCR()
    {
        Vector2 randomDir = new Vector2();
        while(randomDir.magnitude == 0)
        {
            randomDir = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
        }
        randomDir.Normalize();

        ph.Input = randomDir;

        yield return new WaitForSeconds(Random.Range(2.0f, 5.0f));

        ph.Input = Vector2.zero;

        yield return new WaitForSeconds(Random.Range(0.0f, 3.0f));

        currentRoutine =  StartCoroutine(RandomMoveCR());
    }

    #endregion

    #region AnimationFunctions

    private void Idle(float time)
    {

    }

    private void Rotate(float maxTime, Transform target = null)
    {

    }

    private void BackHop(Vector2 target)
    {

    }

    private void SideHop(Vector2 target)
    {

    }

    private void FrontHop(Vector2 target)
    {

    }

    private void SideSweep()
    {

    }

    private void BackLegSweep()
    {

    }

    private void TongueSweep()
    {

    }

    private void TongueStretch()
    {

    }

    #endregion

    #endregion
}
