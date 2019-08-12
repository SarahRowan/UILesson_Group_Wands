using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	private Node currentNode;
	private Node node1;
	private Node node2;

	public GameObject mainText;
	public GameObject leftButtonText;

	// Start is called before the first frame update
    void Start()
    {
		node2 = new Node("Oh no, a witch!", "Fight her!", "Give her your hair", null, null);
		node1 = new Node("You're walking through the woods", "LOOK FOR DANGER", "Chill out", node2, node2);

		currentNode = node1;
		UpdateText(currentNode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void UpdateText(Node newNode) {
		currentNode = newNode;
		mainText.GetComponent<Text>().text = currentNode.mainText;
		leftButtonText.GetComponent<Text>().text = currentNode.leftOption;
	}

	public void ClickLeft() {
		Debug.Log("Got it!");
		if(currentNode.leftNode != null) {
			UpdateText(currentNode.leftNode);
			Debug.Log("updating...");
		}
		else{ Debug.Log("ummmmmm" + currentNode); }
	}
}
