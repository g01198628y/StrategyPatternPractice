using System;

namespace StrategyPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var caculator = new Caculator();
            caculator.SetStrategy(Caculator.Dotype.Multyply);
            var multyplyResult = caculator.Execute(3, 4);
            caculator.Reset();
            caculator.SetStrategy(Caculator.Dotype.Add);
            var addResult = caculator.Execute(4, 5);
            Console.WriteLine($"Multyply:{multyplyResult}, Add:{addResult}");
        }
    }

    //1.先定義一個介面，用這個介面定義一系列演算法
    public interface IStrategy
    {
        int Caculate(int a, int b);
    }

    //2.將加減乘除等一系列的算法實現出來
    public class Add : IStrategy
    {
        public int Caculate(int a, int b)
        {
            return a + b;
        }
    }

    public class Minus : IStrategy
    {
        public int Caculate(int a, int b)
        {
            return a - b;
        }
    }

    public class Multyply : IStrategy
    {
        public int Caculate(int a, int b)
        {
            return a * b;
        }
    }

    public class Divide : IStrategy
    {
        public int Caculate(int a, int b)
        {
            return a / b;
        }
    }

    //3.用一個類裝這個算法，並且用簡單工廠模式封裝一下
    public class Caculator
    {
        private int now;
        private IStrategy strategy;

        //策略模式
        public int Execute(int a, int b)
        {
            return strategy.Caculate(a, b);
        }

        public void Reset()
        {
            now = 0;
        }

        //簡單工廠模式
        public void SetStrategy(Dotype dotype)
        {
            switch (dotype)
            {
                case Dotype.Add:
                    strategy = new Add();
                    break;

                case Dotype.Minus:
                    strategy = new Minus();
                    break;

                case Dotype.Multyply:
                    strategy = new Multyply();
                    break;

                case Dotype.Divide:
                    strategy = new Divide();
                    break;
            }
        }

        public enum Dotype
        {
            Add,
            Minus,
            Multyply,
            Divide
        }
    }
}