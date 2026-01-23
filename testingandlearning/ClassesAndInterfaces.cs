using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingandlearning
{

    #region Structs And Classes

    //scrcut == value type
    //class == reference type

    //struct Point //could also be class. Functionally they are the same thing.
    //{
    //    //constructor
    //    public Point(int startX, int startY)
    //    {
    //        _x = startX;
    //        _y = startY;
    //    }

    //    int _x;

    //    public int GetX()
    //    {
    //        return _x;
    //    }

    //    int _y;

    //    public int GetY()
    //    {
    //        return _y;
    //    }

    //}

    //class Rupee
    //{
    //    //constructor
    //    //contructor is a special method that gets called when we instantiate a rupee.
    //    public Rupee(Point position, ConsoleColor color, int moneyValue)
    //    {
    //        _position = position;
    //        _color = color; 
    //        _moneyValue = moneyValue;
    //    }

    //    Point _position;
    //    public Point GetPosition()
    //    {
    //        return _position;
    //    }

    //    ConsoleColor _color;
    //    public ConsoleColor GetColor()
    //    {
    //        return _color;
    //    }

    //    int _moneyValue;
    //    public int GetMoneyValue()
    //    {
    //        return _moneyValue;
    //    }
    //}

    //Constructor Chaining

    //class Enemy
    //{
    //    private int _health;
    //    private int _maxHealth;

    //    public Enemy(int health)
    //    {
    //        _health = health;
    //        _maxHealth = health;
    //    }

    //    //gives default option
    //    //public Enemy()
    //    //{
    //    //    _health = 100;
    //    //    _maxHealth = 100;
    //    //}
    //}

    //class ExplosiveEnemy : Enemy
    //{
    //    private float _explosionRadius;
    //    public ExplosiveEnemy(int health, float explRadius) : base(health)
    //    {
    //        _explosionRadius = 1;
    //    }
    //}
    #endregion

    #region Interfaces

    //An interface is a contract (that a class agrees to)


    interface IDamageable
    {
        void TakeDamage();
    }

    interface IInteractable
    {
        void Interact();
    }

    interface IConsumable
    {

    }

    interface IPartyMember
    {
        void OnJoinParty();

        void OnLeaveParty();

        void FollowPlayer();
    }

    class Character
    {
        public string _name;
        public int _attackPower;
    }

    class Enemy : Character
    {
        //enemy stuff
    }

    class NPC : Character 
    {
        //npc stuff
    }

    class GiantTrollBoss : Enemy, IPartyMember
    {
        public void FollowPlayer()
        {
            //move to player
        }

        public void OnJoinParty()
        {
            Console.WriteLine("TrollBoss has joined the party");

            //Program.player._partyMembers.Add(this);
        }

        public void OnLeaveParty()
        {
            //leave party
        }
    }

    class Player : Character
    {
        List<IPartyMember> _partymembers = new List<IPartyMember>();

        public void AddPartyMember(IPartyMember newMember)
        {
            _partymembers.Add(newMember);
            newMember.OnJoinParty();
        }
    }

    class Navi : IPartyMember
    {
        public void FollowPlayer()
        {
            //move to player
        }

        public void OnJoinParty()
        {
            Console.WriteLine("Navi has joined the party");
            //Program.player._partyMembers.Add(this);
        }

        public void OnLeaveParty()
        {
            //leave party
        }
    }

    class Health : IDamageable
    {
        public void TakeDamage()
        {

        }
    }

    class Barricade : IDamageable
    {
        bool destroyed = false;

        public void TakeDamage()
        {

        }
    }
    #endregion
}

