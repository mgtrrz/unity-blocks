using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour {

	public GameObject darkBlock;
	public GameObject lightBlock;

	public Sprite darkBlockSprite;
	public Sprite lightBlockSprite;

	public GameObject blockDropper;

	public GameObject newBlock;

	public float blockSize = .15f;

	private List<Sprite> spriteList =  new List<Sprite>();

	public bool gameStart = false;

	// Use this for initialization
	void Start () {
		spriteList.Add(darkBlockSprite);
		spriteList.Add(lightBlockSprite);
	}
	
	// Update is called once per frame
	void Update () {

		if (gameStart) {
		}
		
	}

	public void CreateBlock() {
		newBlock = new GameObject("ActiveSquare");

		GameObject topleft = new GameObject("TL");
		GameObject topright = new GameObject("TR");
		GameObject bottomleft = new GameObject("BL");
		GameObject bottomright = new GameObject("BR");

		topleft.transform.parent = newBlock.transform;
		topright.transform.parent = newBlock.transform;
		bottomleft.transform.parent = newBlock.transform;
		bottomright.transform.parent = newBlock.transform;

		topleft.AddComponent<SpriteRenderer>();
		topleft.GetComponent<SpriteRenderer>().sprite = spriteList[Random.Range(0,2)];
		topleft.transform.position = new Vector3(-blockSize, blockSize, 0);


		topright.AddComponent<SpriteRenderer>();
		topright.GetComponent<SpriteRenderer>().sprite = spriteList[Random.Range(0,2)];
		topright.transform.position = new Vector3(blockSize, blockSize, 0);

		bottomleft.AddComponent<SpriteRenderer>();
		bottomleft.GetComponent<SpriteRenderer>().sprite = spriteList[Random.Range(0,2)];
		bottomleft.transform.position = new Vector3(-blockSize, -blockSize, 0);

		bottomright.AddComponent<SpriteRenderer>();
		bottomright.GetComponent<SpriteRenderer>().sprite = spriteList[Random.Range(0,2)];
		bottomright.transform.position = new Vector3(blockSize, -blockSize, 0);

		newBlock.transform.parent = blockDropper.transform;


	}
}
