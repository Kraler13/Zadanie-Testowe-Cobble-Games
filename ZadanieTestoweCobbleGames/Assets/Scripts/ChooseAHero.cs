using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ChooseAHero : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField] private List<Button> heroButtons;
    [SerializeField] private List<GameObject> heroObj;
    [SerializeField] private CameraMenager CameraMenager;
    [SerializeField] private InputMenager InputMenager;

    private GameObject hoveredHero;
    private int k = 0;
    void Start()
    {
        for (int i = 0; i < heroButtons.Count; i++)
        {
            int heroIndex = i;
            heroButtons[i].onClick.AddListener(() => SelectHero(heroObj[heroIndex]));
        }
    }
    void Update()
    {
        if (hoveredHero != null)
        {
            foreach (var hero in heroObj)
            {
                InputMenager.enabled = false;
            }
            k = 1;
        }
        else if (hoveredHero == null && k == 1)
        {
            foreach (var hero in heroObj)
            {
                InputMenager.enabled = true;
            }
            k = 0;
        }
    }

    void SelectHero(GameObject selectedHero)
    {
        CameraMenager.target = selectedHero.transform;

        Hero heroComponent = selectedHero.GetComponent<Hero>();
        selectedHero.GetComponent<Hero>().enabled = true;
        if (heroComponent != null)
        {
            InputMenager.hero = heroComponent;
        }
        foreach (var hero in heroObj)
        {
            if (hero != selectedHero)
                hero.GetComponent<Hero>().enabled = false;
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        hoveredHero = eventData.pointerEnter;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hoveredHero = null;
    }
}

