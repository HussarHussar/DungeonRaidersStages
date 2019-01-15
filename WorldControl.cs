using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldControl : MonoBehaviour
{
	public bool inCombat;
	public bool stageOver;
	public float tileSizeX = 384;
	public float scrollSpeed;
	private Transform backDrop;
	private Transform floor;
	private Vector3 startPosition;
	private WorldProperties worldProps;
	public GameObject heroIn;
	private GameObject h1;
	private GameObject h2;
	private GameObject h3;
	private GameObject back;

	public WorldControl(HeroQueue q){
		//Spawn appropriate units with correct weapon sprites	
	
	}
    // Start is called before the first frame update
    void Start()
    {
	    //Setup the backdrop (All possible backdrops will later be sorted and stored under the empty object 'backdrops' to be added
	   	back = GameObject.Find("a1z1s1backDrop");
			back.SetActive(true); 


	    	//Retrieves Hero slots and WorldProperties
		h1 = GameObject.Find("HeroInstance1");
		h2 = GameObject.Find("HeroInstance2");
		h3 = GameObject.Find("HeroInstance3");
	    	worldProps = GetComponent<WorldProperties>();


	    //Instantiate Heros by placing unit data from world properties slot into HeroInstance slot and activating instance;
	    if (GetComponent<WorldProperties>().h1 != null){
		    (h1.GetComponent(typeof(StateProperties)) as StateProperties).data = worldProps.h1;
		   h1.SetActive(true);
		//Instantiate(heroIn, transform.Find("Slot1Spawner").transform.position, transform.Find("Slot1Spawner").localRotation, transform);
	    }

	   if (GetComponent<WorldProperties>().h2 != null){
		    (h2.GetComponent(typeof(StateProperties)) as StateProperties).data = worldProps.h2;
		   h2.SetActive(true);
	    }

	   if (GetComponent<WorldProperties>().h3 != null){
		    (h3.GetComponent(typeof(StateProperties)) as StateProperties).data = worldProps.h3;
		   h3.SetActive(true);
	    }




      backDrop = transform.Find("BackDrop"); 
      floor = transform.Find("Floor"); 
      startPosition = backDrop.position;
      tileSizeX = 18.5f;
      scrollSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
       //Checks if there are enemies. If not, alive units run forward in correct formation; 
       //Backdrop movement
      float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeX);
      backDrop.transform.position = startPosition + Vector3.left * newPosition;
      
    }

   
}
