using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseAHero : MonoBehaviour
{
    [SerializeField] private Button heroButton1;
    [SerializeField] private Button heroButton2;
    [SerializeField] private Button heroButton3;
    //[SerializeField] private List<Button> heroButtons;
    //[SerializeField] private List<Transform> hero;
    [SerializeField] protected GameObject heroOne;
    [SerializeField] protected GameObject heroTwo;
    [SerializeField] protected GameObject heroThr;
    [SerializeField] private CameraMenager CameraMenager;
    [SerializeField] private InputMenager InputMenager;
    // Start is called before the first frame update
    void Start()
    {
        heroButton1.onClick.AddListener(OnHeroButtonOneClick);
        heroButton2.onClick.AddListener(OnHeroButtonTwoClick);
        heroButton3.onClick.AddListener(OnHeroButtonThrClick);
        //for (int i = 0; i < heroButtons.Count; i++)
        //{
        //    int heroIndex = i;
        //    heroButtons[i].onClick.AddListener(() => CameraMenager.target = hero[heroIndex]);
        //}
    }

    void OnHeroButtonOneClick()
    {
        Debug.Log("Button One Clicked");
        CameraMenager.target = heroOne.transform;
        InputMenager.hero = heroOne.GetComponent<Hero>();
    }
    private void OnHeroButtonTwoClick()
    {
        Debug.Log("Button Two Clicked");
        CameraMenager.target = heroTwo.transform;
        InputMenager.hero = heroTwo.GetComponent<Hero>();

    }
    private void OnHeroButtonThrClick()
    {
        Debug.Log("Button Thr Clicked");
        CameraMenager.target = heroThr.transform;
        InputMenager.hero = heroThr.GetComponent<Hero>();

    }
}
