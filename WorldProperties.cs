using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldProperties : MonoBehaviour
{
	// World Properties will instanciate Background sprites/object and floor object,
	// and blocks area 
	
	private int area;
	private int zone;
	private int stage;
	public bool inCombat;
	public UnitData h1;
	public UnitData h2;
	public UnitData h3;


	//Gets
	
	public int getArea(){
		return area;	
	}
	
	public int getZone(){
		return zone;
	}

	public int getStage(){
		return stage;
	}
	

	//Sets

	public void setArea(int n){
		area = n;
	}
	public void setStage(int n){
		stage = n;
	}
	public void setZone(int n){
		zone = n;
	}	
	public WorldProperties(int a, int z, int s){
		area = a;	
		zone = z;	
		stage = s;	
		// if a == z == s == 1 then start scene for first level
	
	
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // HeroInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(3,
	 //      GetComponent<Rigidbody2D>().velocity.y);
    
 
    }
}
