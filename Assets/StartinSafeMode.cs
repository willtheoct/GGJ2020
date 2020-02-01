using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class StartinSafeMode: MonoBehaviour
    {
        public GameObject WindowsScreen;
        public GameObject startinSafeMode;
        void Update()
        {
        }
        void OnMouseDown()
        {
            startinSafeMode.SetActive(false);
            WindowsScreen.SetActive(true);
        }
    }
