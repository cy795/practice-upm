using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyPackage
{
    public class TempPrint : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Print(name);
        }

        public void Print(string s) => print(s);
    }
}
