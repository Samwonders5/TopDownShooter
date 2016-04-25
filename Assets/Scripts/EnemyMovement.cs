using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    private NavMeshAgent _navMeshAgent;
    private GameObject _playerObject;

	void Awake ()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _playerObject = GameObject.FindGameObjectWithTag("Player");
	}
	
	void Update ()
    {
        _navMeshAgent.SetDestination(_playerObject.transform.position);
	}
}
