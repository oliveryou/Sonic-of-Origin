﻿using UnityEngine;
using System.Collections;

public class vic : MonoBehaviour {
	float time;
	public byte what;
	bool inin;
	public bool v;
	// Use this for initialization
	void Start () {

		this.transform.localScale=new Vector3(0.001f,0.001f,0.001f);
		this.transform.localPosition = new Vector3 (-5500 + 1000 * what, 300, 0);
		inin = false;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;

		if (time > 0.28f * what && !inin) {
				
			inin=true;
			time=0;
		}


		if (time < 0.5f && inin) {
						
				
			this.transform.localScale = new Vector3 (0.0001f+time*100f, 0.0001f+time*100f,0.0001f+time*100f);

				}



		if (time > 2f && what == 6 && v) {
				
		
						Application.LoadLevel ("credit");
		
				} else if (time > 2f && what == 5 && !v) {
			//Application.LoadLevel ("democardsee");
		
		
		}
	}
}
