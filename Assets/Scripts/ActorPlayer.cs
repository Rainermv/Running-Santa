﻿using UnityEngine;
using System.Collections;

public class ActorPlayer : Actor {
	
	
	private static float JUMP_FORCE = 300;
	private static int JUMPS = 2;
	
	
	private int jumps;
	
	protected override void Awake(){
		base.Awake();	
				
	}
	
	// Use this for initialization
	protected override void Start () {
		base.Start();
		
		jumpForce = new Vector2(0,JUMP_FORCE);
		jumps = JUMPS;
	
	}
	
	// Update is called once per frame
	protected override void Update () {
		base.Update();
							
	}
	
	public void PlayerJump(){
		
		if (jumps > 0){
			rb.velocity = Vector2.zero;
			rb.AddForce(jumpForce);
			
			jumps--;
		}
		
		
	}
	
	protected override void OnCollisionEnter2D(Collision2D collision){
		base.OnCollisionEnter2D(collision);
			
		if (collision.gameObject.tag == "FLOOR"){
			jumps = JUMPS;
		}
	}
	
	
	
}