using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Make sure to add this Using statement in any script accessing the UI!

// This class handles running the actual game. 
public class GameManager : MonoBehaviour
{
	// the node the player is currently on
	private Node currentNode;

	// a list of nodes in the game
	private Node node1;
	private Node node2;

	// references to the main and button text gameobjects, to update their texts 
	public GameObject mainText;
	public GameObject leftButtonText;

	// Start is called before the first frame update
    void Start()
    {
		// initialize all your nodes here, with their proper texts and references. 
		// initialize them in REVERSE order! last nodes first. this prevents the nodes from being null
		// when referenced inside other nodes.
		node2 = new Node("Oh no, a witch!", "Fight her!", "Give her your hair", null, null);
		node1 = new Node("You're walking through the woods", "LOOK FOR DANGER", "Chill out", node2, node2);

		// set the currentNode to the beginning and run the first Update to make sure everything is set up
		currentNode = node1;
		UpdateText(currentNode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	// This method moves the currentNode the node passed in through newNode
	// then updates all text with the text in newNode
	private void UpdateText(Node newNode) {
		currentNode = newNode;
		mainText.GetComponent<Text>().text = currentNode.mainText;
		leftButtonText.GetComponent<Text>().text = currentNode.leftOption;
	}

	// This method is called when the left button is clicked. 
	// It is hooked up in the editor. 
	// If there is a valid left node, UpdateText is called. Otherwise, it only prints to the console.
	public void ClickLeft() {
		Debug.Log("Left Node Clicked!");
		if(currentNode.leftNode != null) {
			UpdateText(currentNode.leftNode);
			Debug.Log("updating...");
		}
		else{ Debug.Log("no node available"); }
	}
}
