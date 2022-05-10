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
        private event Action Eat;
        private event Action SayHello;

        private void Awake()
        {
            //Check and destroys itself when multiple Eventmanager instances are detected
            if (current == null) current = this;
            else Destroy(gameObject);

            DontDestroyOnLoad(gameObject);
        }

        public void StartEating()
        {
            //Invokes when at least 1 event is subscribed to the Eat event
            Eat?.Invoke();
        }

        public void StartStartTalking()
        {
            //Invokes when at least 1 event is subscribed to the SayHello event
            SayHello?.Invoke();
        }
    }
}