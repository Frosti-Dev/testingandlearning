using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingandlearning
{
    //class DebugGameManager : GameManager 
    //{
    //    DebugGameManager()
    //    {

    //    }
    //}


    internal class GameManager
    {
        #region Singleton Pattern
        private static GameManager _instance;

        public static GameManager Instance 
        { get 
            { 
                if(_instance == null)
                {
                    _instance = new GameManager();
                }

                return _instance; 
            } 
        }

        protected GameManager()
        {

        }

        public string myString = "myString";
        public void WriteStuff()
        {
            Console.WriteLine("Stuff");
        }

        #endregion
    }
}