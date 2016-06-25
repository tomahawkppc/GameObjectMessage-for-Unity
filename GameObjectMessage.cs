// Copyright 2016 Area 1
// Verson 1.0.1
// Example call: gameObjectMessage.SendMsg();

using UnityEngine;
using System.Collections;

[System.Serializable]
public class GameObjectMessage {

	public GameObjectMessage() {}

	public GameObjectMessage( GameObject go ) {
		this.go = go;
	}

	public GameObjectMessage( string goName, string methodName ) {
		this.go = GameObject.Find( goName );
		this.goName = goName;
		this.methodName = methodName;
	}

	public GameObjectMessage( GameObject go, string methodName ) {
		this.go = go;
		this.goName = go.name;
		this.methodName = methodName;
	}

	public override string ToString() {
		return 
			//			"go: " + this.go + ", " + 
			"goName: " + this.goName + ", " + 
			"methodName: " + this.methodName;
	}

	public void SendMsg(){
		if( this.go ) this.go.SendMessage( this.methodName );
	}

	public GameObject go;
	public string goName;
	public string methodName;
}
