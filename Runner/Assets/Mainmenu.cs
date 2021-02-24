﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
	public GameObject Header;
	public Button StartGame;
	public Button Credit;
	public Button Quit;
	public Button BackToMain;
	public GameObject creditText;

	void Start()
	{
		StartGame.onClick.AddListener(StartGameButton);
		Credit.onClick.AddListener(CreditButton);
		Quit.onClick.AddListener(QuitButton);
		BackToMain.onClick.AddListener(BackToMainButton);

		StartGame.gameObject.SetActive(true);
		Credit.gameObject.SetActive(true);
		Quit.gameObject.SetActive(true);
		BackToMain.gameObject.SetActive(false);
		creditText.SetActive(false);
	}

	public void StartGameButton()
	{
		//Application.LoadLevel(1);
		SceneManager.LoadScene(1);
	}

	public void CreditButton()
	{
		creditText.SetActive(true);
		Header.SetActive(false);
		StartGame.gameObject.SetActive(false);
		Credit.gameObject.SetActive(false);
		Quit.gameObject.SetActive(false);
		BackToMain.gameObject.SetActive(true);
	}

	public void BackToMainButton()
	{
		creditText.SetActive(false);
		Header.SetActive(true);
		StartGame.gameObject.SetActive(true);
		Credit.gameObject.SetActive(true);
		Quit.gameObject.SetActive(true);
		BackToMain.gameObject.SetActive(false);
	}

	public void QuitButton()
	{
		//Debug.Log("Quit Game");
		Application.Quit();
	}

}