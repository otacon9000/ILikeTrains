﻿using UnityEngine;
using System.Collections;

public class Train : MonoBehaviour {

    public int life;
    public Transform[] waypoints;
	public float speed = 1.0F;

	private float startTime;
    private int actualLife;
	//private bool SetActive (bool value);
	private float journeyLength;
    private int countWaypoints;


	void Start() {
        actualLife = life;
        transform.position = waypoints[0].GetChild(0).position;
        countWaypoints = 0;
		//journeyLength = Vector3.Distance(startMarker.position, endMarker.position);

	}


	void Update() {
        if (!GameController.instance.isPaused)
        {
            /*if(startTime == 0)
                startTime = Time.time;
            float distCovered = (Time.time - startTime) * speed;
            float fracJourney = distCovered / journeyLength;
            transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);*/
            if (Vector3.Distance(transform.position , waypoints[countWaypoints].GetChild(0).position) <= 0.01)
            {
                if ((countWaypoints < (waypoints.Length - 1)))
                {
                    countWaypoints++;
                }
                else
                {
                    //
                }
                transform.LookAt(waypoints[countWaypoints].GetChild(0).position);
            }
            transform.position = Vector3.MoveTowards(transform.position, waypoints[countWaypoints].GetChild(0).position, Time.deltaTime*speed);
        }

	}

    public void Activate()
    {
        this.gameObject.SetActive(true);
    }
	
    public void GetDamage(int damage)
    {
        actualLife -= damage;
        if (actualLife <= 0)
            this.gameObject.SetActive(false);
    }

}