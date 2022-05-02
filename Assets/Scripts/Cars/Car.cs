using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cars
{
    public class Car : MonoBehaviour
    {
        [SerializeField] private string status; //fail, run, stopped, finish
        [SerializeField] private string name;
        [SerializeField] private Model model;

        public string getStatus()
        {
            return status;
        }

        public void setStatus(string status)
        {
            if (!(status.Equals("run") || status.Equals("fail") || status.Equals("stopped") || status.Equals("finish")))
                throw new UnityException("Invalid status");

            this.status = status;
        }
    }
}
