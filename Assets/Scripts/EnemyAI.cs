using UnityEngine.AI;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public Animator animator;
    private NavMeshAgent agent;
    public AudioSource breathing;
    public AudioSource panting;

    private enum State
    {
        Sleeping,
        Seizuring,
        Chasing
    }

    private State currentState = State.Sleeping;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.isStopped = true;
        breathing.Play();
    }

    void Update()
    {
        if (currentState == State.Chasing)
        {
            agent.SetDestination(player.position);
        }
    }

    public void Seizure()
    {
        currentState=State.Seizuring;

        if(currentState == State.Seizuring)
        {
            animator.SetTrigger("IsSeizure");
        }
    }
    public void WakeUp()
    {
        if (currentState == State.Seizuring)
        {
            breathing.Stop();
            panting.Play();
            currentState = State.Chasing;
            agent.baseOffset=0;
            animator.SetTrigger("IsCrawl");
            agent.isStopped = false;
        }
    }
    public void BreathingSound()
    {
        panting.Stop();
        breathing.Play();
    }
}
