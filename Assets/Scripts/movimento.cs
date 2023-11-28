using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class movimento : MonoBehaviour
{

    public float distanciaMin = 1;
    public Transform alvo;

    private NavMeshAgent navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, alvo.position) <= distanciaMin)
        return;

        navMeshAgent.SetDestination(alvo.position);
    }
}
