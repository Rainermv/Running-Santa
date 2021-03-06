﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ActorComponent : MonoBehaviour {
	
	protected Rigidbody2D rb;
	protected Collider2D[] colls;

	protected World world;
	public Actor actor;

    SpriteRenderer rend;

    //List<GameObject> childrendObjects = new List<GameObject>();


    public Vector2 getSpriteSize(){

		Vector2 size = Vector2.zero;

		if (this.rend != null) {

			Bounds b = rend.bounds;

			//size = new Vector2 (b.max.x - b.min.x, b.

		}

		return size;



	}

	//public Vector2 moveVector = Vector2.zero;
				
	protected virtual void Awake(){
		
		rb = GetComponent<Rigidbody2D>();
		colls =  GetComponents<Collider2D>();

        rend = GetComponentsInChildren<SpriteRenderer>()[0];

        world = World.GetInstance();
	}

	
	// Use this for initialization
	protected virtual void Start () {
		
	}
	
	// Update is called once per frame
	protected virtual void Update () {

		if (transform.position.x < world.X_REMOVE && !actor.indestructable) {

			Destroy (gameObject);

		}

	}
	
	protected virtual void FixedUpdate () {

		if (actor.isKinematic){

			if (actor.hasRigidbody) {
				//moveVector = actor.velocity;

				rb.MovePosition (rb.position + (world.BASE_SPEED * actor.worldMovementMultiplier) * Time.fixedDeltaTime);
				//moveVector += world.BASE_SPEED;
			} else {
				Vector2 pos2d = transform.position;
				transform.position = pos2d + (world.BASE_SPEED * actor.worldMovementMultiplier) * Time.fixedDeltaTime;

				//transform.position = transform.position + (world.BASE_SPEED * actor.worldMovementMultiplier) * Time.fixedDeltaTime;

			}



		}

			

		//this.rb.velocity = velocityVector;
	}

	/*
	public void setSpeed( Vector2 moveVector){

		moveVector += world.BASE_SPEED;
		this.rb.velocity = moveVector;

	}
	*/
	protected virtual void OnCollisionEnter2D(Collision2D collision){

	}

	protected virtual void OnCollisionExit2D(Collision2D collision){

	}

	protected virtual void OnCollisionStay2D(Collision2D collision){

	}

    protected virtual void OnTriggerEnter2D(Collider2D collider)
    {

    }

    protected virtual void OnTriggerExit2D(Collider2D collider)
    {

    }

    protected virtual void OnTriggerStay2D(Collider2D collider)
    {

    }


    public Bounds getBounds(){

		Bounds bounds = new Bounds();

		foreach (Collider2D coll in colls) {

			bounds.Encapsulate (coll.bounds);

		}

		return bounds;

	}

    public Bounds getRendererBounds() {

        return rend.bounds;

    }

	public Collider2D[] getColliders(){
		return colls;
	}


	/*
	public void ActionJump(){
		
		rb.AddForce(actor.jumpForce);
		
	}
	
	protected virtual void OnCollisionEnter2D(Collision2D collision){
		
		if (collision.gameObject.tag == "FLOOR"){
			isTouchingFloor = true;
		}
	}
	
	protected virtual void OnCollisionExit2D(Collision2D collision){
		
		if (collision.gameObject.tag == "FLOOR"){
			isTouchingFloor = false;
		}
	}
	
	public void setSpeed( Vector2 moveVector){
		
		moveVector += world.BASE_SPEED;
		this.rb.velocity = this.moveVector;
	
	}
	*/
}
