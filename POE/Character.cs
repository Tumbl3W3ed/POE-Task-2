using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    abstract class Character : Tile
    {
        protected int Hp { get; set; }
        protected int MaxHP { get; set; }
        protected int Damage { get; set; }
        protected Tile[] HeroVision { get; set; }// up down left right
        protected bool Dead { get; set; }
        public enum MovementEnum 
        {
            NoMovement, Up, Down, Left, Right
        }
        public Character(int y, int x, int maxhp, int damage) : base(y, x)
        {
            MaxHP = maxhp;
            Hp = maxhp;
            Damage = damage;
        }

        public virtual void Attack(Character target)
        {
            target.Hp -= this.Damage;
            if (target.Hp <= 0)
            {
                target.Dead = true;
            }
        }

        public virtual bool CheckRange(Character target)
        {
            if (DistanceTo(target) <= 1 && DistanceTo(target) >= -1)
            {
                return true;
            }
            return false;
        }

        public void Move(MovementEnum move)
        {
            if (move == MovementEnum.Down)
            {
                this.Y++;
            }
            if (move == MovementEnum.Up)
            {
                this.Y--;
            }
            if (move == MovementEnum.Right)
            {
                this.X++;
            }
            if (move == MovementEnum.Left)
            {
                this.X--;
            }

        }

        public bool IsDead()
        {
            return Dead;
        }
        private int DistanceTo(Character target)
        {
            return Math.Abs(target.X - this.X) + Math.Abs(target.Y - this.Y);
        }

        public abstract MovementEnum ReturnMove(MovementEnum move);

        public abstract override string ToString();
    }
}
