using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;


public class Player : MonoBehaviour
{
    public Camera _CameraControl;
    public NavMeshAgent _Agent;
    public ThirdPersonCharacter _Character;
    [SerializeField] Transform _WaipointOne;
    [SerializeField] Transform _WaipointTwo;

    public static int _Kills;


    private void Start()
    {
        _Agent.updatePosition = false;
    }

    private void Update()
    {
        if (_Agent.remainingDistance > _Agent.stoppingDistance)
        {
            _Character.Move(_Agent.desiredVelocity, false, false);
        }
        else
        {
            _Character.Move(Vector3.zero, false, false);
        }

        WeapPoint();
    }
    
    private void WeapPoint()
    {
        if (_Kills == 2)
        {
            _Agent.SetDestination(_WaipointOne.position);
        }
        else if (_Kills == 5)
        {
            _Agent.SetDestination(_WaipointTwo.position);
            _Kills = 0;
        }
    }
}
