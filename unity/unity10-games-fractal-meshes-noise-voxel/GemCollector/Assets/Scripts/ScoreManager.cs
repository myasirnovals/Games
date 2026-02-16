using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
	public int Score = 0;
	public int TargetScore = 400;
	public int timerPerLevel = 30;
	public Text TxtScore = null;
	public Text TxtTime = null;
	public GameObject YouWon = null;
	public GameObject GameOver = null;

	private float clockSpeed = 1f;

	void Awake()
	{
		TxtScore.text = "Score: " + Score + " / " + TargetScore;
		InvokeRepeating("DeductTimer", 0f, clockSpeed);
	}

	private void DeductTimer()
	{
		timerPerLevel--;
		TxtTime.text = "Time: " + timerPerLevel;

		if (timerPerLevel <= 0)
			CheckForGameOver();
	}

	public void AddPoints(int points)
	{
		Score += points;
		TxtScore.text = "Score: " + Score + " / " + TargetScore;

		if (Score >= TargetScore)
		{
			Time.timeScale = 0f;
			YouWon.SetActive(true);
		}
	}

	private void CheckForGameOver()
	{
		Time.timeScale = 0f;

		if (Score >= TargetScore && YouWon != null)
			YouWon.SetActive(true);
		else if (Score < TargetScore && GameOver != null)
			GameOver.SetActive(true);
	}
}
