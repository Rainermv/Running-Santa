﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum FloorPlatformType {

	LEFT,
	CENTER,
	RIGHT

}

public class FloorPlatformTemplateGenerator  {

	private Dictionary<FloorPlatformType, TileType[,]> templates = new  Dictionary<FloorPlatformType, TileType[,]>() ;

	private static FloorPlatformTemplateGenerator instance;

	private FloorPlatformTemplateGenerator(){


		Generate (World.getInstance().FLOOR_PLATFORM_SIZE);
	}
	public static FloorPlatformTemplateGenerator getInstance(){
		if (instance == null){
			instance = new FloorPlatformTemplateGenerator();
		}
		return instance;
	}

	private void Generate(int size){
	
		TileType[,] left = new TileType[size,1];
		TileType[,] center = new TileType[size,1];
		TileType[,] right = new TileType[size,1];

		left [0, 0] = TileType.SNOW_SURFACE_LEFT;
		center [0, 0] = TileType.SNOW_SURFACE_CENTER;
		right [0, 0] = TileType.SNOW_SURFACE_CENTER;

		for (int i = 1; i < size -1; i++) {
			left [i,0] = TileType.SNOW_SURFACE_CENTER;
			center [i,0] = TileType.SNOW_SURFACE_CENTER;
			right [i,0] = TileType.SNOW_SURFACE_CENTER;
		}

		left [size-1, 0] = TileType.SNOW_SURFACE_CENTER;
		center [size-1, 0] = TileType.SNOW_SURFACE_CENTER;
		right [size-1, 0] = TileType.SNOW_SURFACE_RIGHT;

		templates.Add(FloorPlatformType.LEFT, left);
		templates.Add(FloorPlatformType.CENTER, center);
		templates.Add(FloorPlatformType.RIGHT, right);

	}
		


	public TileType[,] Get(FloorPlatformType key){

		return templates[key];

	}





}
