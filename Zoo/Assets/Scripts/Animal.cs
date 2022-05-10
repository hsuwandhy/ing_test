using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Zoo
{
    public class Animal : MonoBehaviour
    {
        virtual public string name;
        [SerializeField]
        virtual private GameObject Balloon;
        [SerializeField]
        virtual private Text text;  
        [SerializeField]
        virtual private bool carnivourous;

        virtual public string greeting = "";
        virtual public string eatingSounds = "";

        virtual public void Start()
        {
            EventManager.current.Eat += EatLeaves;
            EventManager.current.SayHello += SayHello;
        }
        virtual public void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "splash";
        }

        virtual public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "munch munch lovely";
        }

        virtual public void EatMeat()
        {
            Balloon.SetActive(true);
            text.text = "nomnomnom thx mate";
        }

        virtual public void OnDisable()
        {
            EventManager.current.Eat -= EatLeaves;
            EventManager.current.SayHello -= SayHello;
        }
    }
}

