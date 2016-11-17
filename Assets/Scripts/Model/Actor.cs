﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum ColliderType {

	Box,
	Circle

}

public class ColliderInfo{

	public ColliderType type = ColliderType.Box;
	public Vector2 size = new Vector2(1,1);
	public Vector2 offset = new Vector2(0,0);
	public string materialKey = "Default";

}

public abstract class Actor {

	protected World world = World.getInstance();

	public int id = 0;

	public Vector2 startingPosition = Vector2.zero;

	public string tag = "Default";
	public int layer = Layers.FLOORS;

	public Color tint = Color.white;
	
	public string name = "Generic Actor";
	public string spriteKey = "default";
	public int depth = 0;

	public Vector2 scale = new Vector2(1,1);

	public List<ColliderInfo> colliders = new List<ColliderInfo> ();

	//public Vector2 colliderSize = new Vector2(1,1);
	//public Vector2 colliderOffset = new Vector2(0,0);
	
	//public bool useGravity;
	public bool isKinematic = false;
	public Vector2 velocity = Vector2.zero;
	public bool constrainRotation = false;
	public bool constrainMovement = false;

	public bool affectedByWorldMovement = true;

}
