using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{
	public Text answerText;
	public AnswerData answerData;
	public void Setup(AnswerData data)
	{
		answerData = data;
		answerText.text = answerData.answerText;
	}
}
