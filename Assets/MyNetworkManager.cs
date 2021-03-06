﻿using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

	public void MyStartHost () {
		Debug.Log (Time.timeSinceLevelLoad + " Starting Host");
		StartHost ();
	}

	public override void OnStartHost () {
		Debug.Log ( Time.timeSinceLevelLoad + " Host Started");
	}

	public override void OnStartClient (NetworkClient myClient) {
		Debug.Log (Time.timeSinceLevelLoad + " Client Start Requested");
		InvokeRepeating("PrintDots", 0f, 1f);
	}

	public override void OnClientConnect (NetworkConnection conn) {
		CancelInvoke();
		Debug.Log (Time.timeSinceLevelLoad + " Client Connected to IP: " + conn.address);
	}

	void PrintDots () {
		Debug.Log(".");
	}
}