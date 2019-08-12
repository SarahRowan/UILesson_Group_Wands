using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
	public string mainText, leftOption, rightOption;
	public Node leftNode, rightNode;

	public Node(string p_mainText, string p_leftOption, string p_rightOption, Node p_leftNode, Node p_rightNode) {
		mainText = p_mainText;
		leftOption = p_leftOption;
		rightOption = p_rightOption;
		leftNode = p_leftNode;
		rightNode = p_rightNode;
	}
}
