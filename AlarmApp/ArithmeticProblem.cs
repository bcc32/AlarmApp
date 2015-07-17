using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmApp
{
    public enum DifficultyLevel
    {
        EASY,
        MEDIUM,
        HARD,
    }

    interface IArithmeticProblem
    {
        decimal Answer { get; }
    }

    class ArithmeticProblem : IArithmeticProblem
    {
        public const int NUM_TYPES_PUZZLE = 2;
        public static Random rng = new Random();

        virtual public decimal Answer
        {
            get { return 0; }
        }

        public static ArithmeticProblem MakeRandomProblem(DifficultyLevel level)
        {
            switch (rng.Next(NUM_TYPES_PUZZLE))
            {
                case 0:
                    return new AdditionProblem(level);
                case 1:
                    return new MultiplicationProblem(level);
                default:
                    throw new Exception();
            }
        }
    }

    class AdditionProblem : ArithmeticProblem
    {
        private decimal addend;
        private decimal augend;

        public AdditionProblem(DifficultyLevel level)
        {
            switch (level)
            {
                case DifficultyLevel.EASY:
                    SetupInstance(rng.Next(10, 100), rng.Next(10, 100));
                    break;
                case DifficultyLevel.MEDIUM:
                    SetupInstance(rng.Next(100, 1000), rng.Next(100, 1000));
                    break;
                case DifficultyLevel.HARD:
                    SetupInstance(rng.Next(1000, 10000), rng.Next(1000, 10000));
                    break;
                default:
                    throw new ArgumentException("Not a valid difficulty level");
            }
        }

        private void SetupInstance(decimal addend, decimal augend)
        {
            this.addend = addend;
            this.augend = augend;
        }

        override public decimal Answer
        {
            get
            {
                return addend + augend;
            }
        }

        override public string ToString()
        {
            return addend.ToString() + " + " + augend.ToString();
        }
    }

    class MultiplicationProblem : ArithmeticProblem
    {
        private decimal multiplicand;
        private decimal multiplier;

        public MultiplicationProblem(DifficultyLevel level)
        {
            switch (level)
            {
                case DifficultyLevel.EASY:
                    SetupInstance(rng.Next(10, 100), rng.Next(1, 10));
                    break;
                case DifficultyLevel.MEDIUM:
                    SetupInstance(rng.Next(10, 100), rng.Next(10, 100));
                    break;
                case DifficultyLevel.HARD:
                    SetupInstance(rng.Next(100, 1000), rng.Next(10, 100));
                    break;
                default:
                    throw new ArgumentException("Not a valid difficulty level");
            }
        }

        private void SetupInstance(decimal multiplicand, decimal multiplier)
        {
            this.multiplicand = multiplicand;
            this.multiplier = multiplier;
        }

        override public decimal Answer
        {
            get
            {
                return multiplicand * multiplier;
            }
        }

        override public string ToString()
        {
            return multiplicand.ToString() + " * " + multiplier.ToString();
        }
    }
}
