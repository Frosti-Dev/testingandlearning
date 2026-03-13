using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace testingandlearning
{
    class Program
    {
        //public static Player player;

        static void Main(string[] args)
        {
            #region Classes and Structs
            //Point p = new Point(10, 20);

            //p._x = 100;
            //p._y = 200;

            //Point rupeeSpawnPos = new Point(startX: 5, startY: 5);
            //Rupee myRupee = new Rupee(
            //    position: rupeeSpawnPos, 
            //    color: ConsoleColor.Green, 
            //    moneyValue: 10
            //    );
            //do this if line is too long



            //Console.BackgroundColor = myRupee.GetColor();

            //Point rupeePoint = myRupee.GetPosition();
            //Console.SetCursorPosition(rupeePoint.GetX(), rupeePoint.GetY());

            //Console.Write(" ");
            //Console.ReadKey();

            //rectangle class in another file

            //Rectangle rect = new Rectangle();


            //float recWidth = rect.Width;

            //Console.ReadKey();
            //

            //chaining
            //Enemy e = new Enemy(health: 100);
            #endregion


            #region Interactables

            //Health health = new Health();

            //IDamageable damageable = new Health();

            //IDamageable barricade = new Barricade();

            //raycast at something
            //see if any components on gameobject are IInteractable
            //if they are (meaning , they have signed a contract)
            //Interact Method
            //if player presses E
            //We call IInteractable.Interact();

            //player = new Player();

            //Character trollBoss = new GiantTrollBoss();

            //if(trollBoss is IPartyMember member)
            //{
            //    Debug.WriteLine("Yes trollboss implements IPartyMember");

            //    player.AddPartyMember(member);
            //}

            //IPartyMember navi = new Navi();

            //player.AddPartyMember(navi);

            #endregion


            #region Singleton Pattern

            //GameManager.Instance.WriteStuff();

            //Console.ReadKey();
            #endregion


            #region Delegates
            //Delegate is a type that stores methods. Can store mulitiple methods.

            //Action -> action is a built in delegate type that c# gives us.
            //95% of 'event' scenarios, we can use Action!

            //Action myAction = null;

            //myAction += Method1;
            //myAction += Method2;


            ///Long form of null check
            //if (myAction != null)
            //{
            //    myAction(); //shortform of myAction.Invoke();
            //}

            //else
            //{
            //    Console.WriteLine("myAction = null. Couldn't invoke!");
            //}

            /// ? null conditional operator

            //myAction?.Invoke(); //short form

            //Console.WriteLine("removing method1");

            //myAction -= Method1;

            //myAction();

            //Console.ReadKey();

            ///Object ref with Actions
            
            //Player player = new Player();

            ////Enemy enemy = new Enemy(player);

            //List<Enemy> allEnemies = new List<Enemy>();

            //for(int i = 0; i <10; i++)
            //{
            //    Enemy e = new Enemy(player);
            //    allEnemies.Add(e);
            //}

            ////for each enemey
            //    //if theyre dead,
            //    //enemy.Unsubscribe()
            //    //remove them from the list

            /////Garbage collector would realize that the removed enemy no long is referenced
            //    //by any other objects
            //    //it would free up the memory


            /////in unity;
            //    //OnEnable: subscribe to event on enable
            //    //OnDisable: unsubscribe to event on disable


            //player.TakeDamage(10);

            //Console.ReadKey();

            #endregion
        }

        #region Action Methods
        static void Method1()
        {
            Console.WriteLine("called method1");
        }

        static void Method2()
        {
            Console.WriteLine("called method2");
        }
        #endregion

    }
}
