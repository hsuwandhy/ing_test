using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject lion, hippo, pig, tiger, zebra, elephant, monkey;

        [SerializeField]
        public InputField input;

        //public List<Animal> animalsList = new List<Animal>();

        private void Start()
        {
            Lion henk = Instantiate(lion, transform).GetComponent<Lion>();
            henk.name = "henk";
            //AddToList(henk);

            Hippo elsa = Instantiate(hippo, transform).GetComponent<Hippo>();
            elsa.name = "elsa";
            //AddToList(elsa);

            Pig dora = Instantiate(pig, transform).GetComponent<Pig>();
            dora.name = "dora";
           // AddToList(dora);

            Tiger wally = Instantiate(tiger, transform).GetComponent<Tiger>();
            wally.name = "wally";
            //AddToList(wally);

            Zebra marty = Instantiate(zebra, transform).GetComponent<Zebra>();
            marty.name = "marty";
           // AddToList(marty);

            Elephant dumbo = Instantiate(elephant, transform).GetComponent<Elephant>();
            dumbo.name = "dumbo";
            //AddToList(dumbo);

            Monkey george = Instantiate(monkey, transform).GetComponent<Monkey>();
            george.name = "george";
            //AddToList(george);
        }

        //public void AddToList(Animal item)
        //{
        //    animalsList.Add(item);
        //}
    }
}
