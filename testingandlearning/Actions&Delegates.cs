using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingandlearning
{
    class Player
    {
        public Action<int> _tookDamage = null;

        int _health = 100;

        public void TakeDamage(int amount)
        {
            _health -= amount;

            _tookDamage?.Invoke(amount);
        }
    }

   class Enemy
    {

        Player _player;

        public Enemy(Player player)
        {
            player._tookDamage += HandlePlayerTookDamage;
            _player = player;
        }

        public void Unsubscribe()
        {
            _player._tookDamage -= HandlePlayerTookDamage;
        }

        void HandlePlayerTookDamage(int amount)
        {
            Console.WriteLine($"Enemy reacts to player taking damage! {amount} DMG was taken.");
        }
    }
}
