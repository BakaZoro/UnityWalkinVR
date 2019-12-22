using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSphere : MonoBehaviour {

	public Transform nexSphere;
	public Transform curSphere;
	public float timer = 0.0f;
	Vector3 nextpos;
	Vector3 newpos;
	public bool move=false;
	float x_cord;
	float z_cord;

	private void OnTriggerEnter(Collider obj){
		
		if (obj.tag == "Player") {
		
			move = true;

			while (timer <= 2.5f) {
				timer += Time.deltaTime;
			}

			//Position of the camera

			x_cord = Camera.main.transform.parent.position.x;
			z_cord = Camera.main.transform.parent.position.z;

			//Position of the next sphere
			nextpos = nexSphere.position;

			//Check if the collider is on x-axis or z-axis

			if (transform.position.x == curSphere.position.x) {

				newpos = new Vector3 (x_cord, 0, 0) + nextpos;	
	
			} 
			else if (transform.position.z == curSphere.position.z) {
			
				newpos = new Vector3 (0, 0, z_cord) + nextpos;

			}

			Camera.main.transform.parent.position = newpos;
			
			}
		}
	}
		

