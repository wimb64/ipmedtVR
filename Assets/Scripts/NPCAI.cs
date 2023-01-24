using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCAI : MonoBehaviour
{

    public GameObject destinationPoint1;
    public GameObject destinationPoint2;
    public GameObject sceneControllerObject;
    public SceneController script;
    //GameObject[] destinationPoints;
    int fase;
    float remDistance;

    NavMeshAgent agent;
    Animator animator;
    

    void Start()
    {
        script = sceneControllerObject.GetComponent<SceneController>();

        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        //agent.updatePosition = false;
        //destinationPoints = new GameObject[] { destinationPoint1, destinationPoint2 };
        //fase = 0;
    }

    void Update()
    {
        fase = script.fase;

        switch (fase)
        {
            case 0:
                

                break;
            case 1:
                agent.SetDestination(destinationPoint1.transform.position);
                remDistance = agent.remainingDistance;
                //if (0.05f > remDistance && remDistance > 0.0f)
                break;
            case 2:

                break;
            case 3:

                break;
            default:
                break;
        };

        ////agent.SetDestination(destinationPoint1.transform.position);

        //agent.SetDestination(destinationPoints[fase].transform.position);

        ////Debug.Log("remaining distance: " + agent.remainingDistance);
        //remDistance = agent.remainingDistance;

        //if (0.005f > remDistance && remDistance > 0.0f)
        //{
        //    fase += 1;
        //}

        ////dat ie gaat lopen (animatie) als zn snelheid groter is dan 0.5, en anders stopt
        animator.SetBool("isWalking", (agent.velocity.magnitude > 0.5f));

    }
}
