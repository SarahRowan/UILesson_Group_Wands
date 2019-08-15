// This class is NOT a monobehavior! That's because we aren't using any unity-specific systems.
// This node just holds data, so the game knows what to load when the player clicks. 
// It's part of a structure called Linked Lists, which just means a class that takes an object of its own type as a parameter. 
// We use these to make paths in our data... like we need to write narrative games!
public class Node
{
	// this syntax, with the comma-separated names, lets us initialize lots of variables of the same type at once.
	// mainText, leftOption, and rightOption are all public strings.
	public string mainText, leftOption, rightOption;

	//leftNode and rightNode are both Nodes.
	public Node leftNode, rightNode;

	// This is a constructor! It's just like we used in Processing. This constructor allows our Node class
	// to take in parameters. 
	// Using "p_" in front of a variable is fairly common best practice. It lets us name our parameters the same
	// as the values they're going to fill, without the risk of confusing them. 
	public Node(string p_mainText, string p_leftOption, string p_rightOption, Node p_leftNode, Node p_rightNode) {
		mainText = p_mainText;
		leftOption = p_leftOption;
		rightOption = p_rightOption;
		leftNode = p_leftNode;
		rightNode = p_rightNode;
	}
}
