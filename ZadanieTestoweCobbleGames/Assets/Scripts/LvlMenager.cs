using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlMenager : MonoBehaviour
{
    [SerializeField] private List<Hero> heroList = new List<Hero>();
    void Awake()
    {
        for (int i = 0; i < heroList.Count; i++)
        {
            heroList[i].speed = Random.Range(1f, 5f);
            heroList[i].maneuverability = Random.Range(1f, 3f);
            heroList[i].endurance = Random.Range(50f, 100f);
        }
    }
}
