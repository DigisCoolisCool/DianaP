using UnityEngine;
using System.Collections;

public class NPC_1 : NPC {
	 
	// Use this for initialization
	public override void OnSetUpDialogue() {
		Speech.AddDialogue("0","Hello traveller!", "1");
		Speech.AddDialogue("1", "Welcome to our planet!", "2");
		Speech.AddDialogue("2", "Find powerup and you can jump higher", "3");
		Speech.AddDialogue("3", "then go to next island");
	}

	// Triggered when the player comes in range of the NPC
	public override void OnTriggerNPC( Collider other ){

		Speech.SetDialogue("0");
}
}
