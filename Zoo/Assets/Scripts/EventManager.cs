using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Zoo
{
    public class EventManager : MonoBehaviour
    {
        public static EventManager current;

        // Start is called before the first frame update
        public static event Action EatMeat;
        public static event Action EatLeaves;
        public static event Action DoTrick;
        public static event Action SayHello;

        //private void Awake()
        //{
        //    //Check and destroys itself when multiple Eventmanager instances are detected
        //    if (current == null) current = this;
        //    else Destroy(gameObject);

        //    DontDestroyOnLoad(gameObject);

        //}

        public void StartEatingMeat()
        {
            //Invokes when at least 1 event is subscribed to the EatMeat event
            EatMeat?.Invoke();
        }

        public void StartEatingLeaves()
        {
            //Invokes when at least 1 event is subscribed to the EatLeaves event
            EatLeaves?.Invoke();
        }

        public void StartDoingTricks()
        {
            //Invokes when at least 1 event is subscribed to the DoTrick event
            DoTrick?.Invoke();
        }

        public void StartTalking()
        {
            //Invokes when at least 1 event is subscribed to the SayHello event
            SayHello?.Invoke();
        }
    }
}