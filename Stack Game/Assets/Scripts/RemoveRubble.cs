using UnityEngine;
using System.Collections;

public class RemoveRubble : MonoBehaviour {

    private void onCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
