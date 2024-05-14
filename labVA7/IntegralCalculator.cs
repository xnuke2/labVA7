using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labVA7
{
    internal class IntegralCalculator
    {
        double StartInterval = 1;
        double EndInterval = 3;
        double ErrorRate = 0.001;
        int numOfInterval = 10;
        public struct rezult
        {
            public double value;
            public double ErrorRate;
        }
        public IntegralCalculator(double _ErrorRate) 
        { 
            ErrorRate = _ErrorRate;
        }
        public double findFunctionValue(double x)
        {
           //return 1/((1+2*Math.Pow(Math.Sin(x), 2))*Math.Sqrt(1-0.64*Math.Pow(Math.Sin(x),2)));
           return Math.Pow(x, 2)*Math.Sin(x);
        }

        public rezult FindIntegralMiddleRectangle()
        {
            int k = 2;
            double Rezult = 0;
            double step = (EndInterval-StartInterval)/(numOfInterval);
            for (int i = 0; i < numOfInterval; i++)
            {
                double x1 =StartInterval+ step*i;
                Rezult += findFunctionValue(x1+step / 2) * step;
            }
            int tmpNumOfInterval = numOfInterval;
            double LastRezult = Rezult;
            Rezult *= 2;
            while (Math.Abs(Rezult - LastRezult) / (Math.Pow(2, k) - 1) >= ErrorRate)
            {
                LastRezult = Rezult;
                tmpNumOfInterval *= 2;
                step = (EndInterval - StartInterval) / (tmpNumOfInterval);
                Rezult = 0;
                for (int i = 0; i < tmpNumOfInterval; i++)
                {
                    double x1 = StartInterval + step * i;
                    Rezult += findFunctionValue(x1 + step / 2) * step;
                }
            }
            rezult rez =new rezult();
            rez.value = Rezult;
            rez.ErrorRate = Math.Abs(Rezult - LastRezult) / (Math.Pow(2, k) - 1);
            return rez;
        }
        public rezult FindIntegralLeftRectangle()
        {
            int k = 1;
            double Rezult = 0;
            double step = (EndInterval - StartInterval) / (numOfInterval);
            for (int i = 0; i < numOfInterval; i++)
            {
                double x1 = StartInterval + step * i;
                Rezult += findFunctionValue(x1) * step;
            }
            int tmpNumOfInterval = numOfInterval;
            double LastRezult = Rezult;
            Rezult *= 2;
            while (Math.Abs(Rezult - LastRezult) / (Math.Pow(2, k) - 1) >= ErrorRate)
            {
                LastRezult = Rezult;
                tmpNumOfInterval *= 2;
                step = (EndInterval - StartInterval) / (tmpNumOfInterval);
                Rezult = 0;
                for (int i = 0; i < tmpNumOfInterval; i++)
                {
                    double x1 = StartInterval + step * i;
                    Rezult += findFunctionValue(x1) * step;
                }
            }
            rezult rez = new rezult();
            rez.value = Rezult;
            rez.ErrorRate = Math.Abs(Rezult - LastRezult) / (Math.Pow(2, k) - 1);
            return rez;
        }
        public rezult FindIntegralRightRectangle()
        {
            int k = 1;
            double Rezult = 0;
            double step = (EndInterval - StartInterval) / (numOfInterval);
            for (int i = 0; i < numOfInterval; i++)
            {
                double x1 = StartInterval + step * (i+1);
                Rezult += findFunctionValue(x1) * step;
            }
            int tmpNumOfInterval = numOfInterval;
            double LastRezult = Rezult;
            Rezult *= 2;
            while (Math.Abs(Rezult - LastRezult) / (Math.Pow(2, k) - 1) >= ErrorRate)
            {
                LastRezult = Rezult;
                tmpNumOfInterval *= 2;
                step = (EndInterval - StartInterval) / (tmpNumOfInterval);
                Rezult = 0;
                for (int i = 0; i < tmpNumOfInterval; i++)
                {
                    double x1 = StartInterval + step * (i + 1);
                    Rezult += findFunctionValue(x1) * step;
                }
            }
            rezult rez = new rezult();
            rez.value = Rezult;
            rez.ErrorRate = Math.Abs(Rezult - LastRezult) / (Math.Pow(2, k) - 1);
            return rez;
        }
        public rezult FindIntegralTrapezoid()
        {
            int k = 2;
            double Rezult = 0;
            double step = (EndInterval - StartInterval) / (numOfInterval);
            for (int i = 0; i < numOfInterval; i++)
            {
                double x1 = StartInterval + step * (i);
                double x2 = StartInterval + step * (i + 1);
                Rezult += (findFunctionValue(x1)+findFunctionValue(x2))/2* step;
            }
            int tmpNumOfInterval = numOfInterval;
            double LastRezult = Rezult;
            Rezult *= 2;
            while (Math.Abs(Rezult - LastRezult) / (Math.Pow(2, k) - 1) >= ErrorRate)
            {
                LastRezult = Rezult;
                tmpNumOfInterval *= 2;
                step = (EndInterval - StartInterval) / (tmpNumOfInterval);
                Rezult = 0;
                for (int i = 0; i < tmpNumOfInterval; i++)
                {
                    double x1 = StartInterval + step * (i);
                    double x2 = StartInterval + step * (i + 1);
                    Rezult += (findFunctionValue(x1) + findFunctionValue(x2)) / 2 * step;
                }
            }
            rezult rez = new rezult();
            rez.value = Rezult;
            rez.ErrorRate = Math.Abs(Rezult - LastRezult) / (Math.Pow(2, k) - 1);
            return rez;
        }
        public rezult FindIntegralSimpson()
        {
            int k = 4;
            double step = (EndInterval - StartInterval) / (numOfInterval);
            double Rezult =step/3* findFunctionValue(StartInterval);
            Rezult += step / 3 * findFunctionValue(EndInterval);
            for (int i = 1; i < numOfInterval; i++)
            {
                double x = StartInterval + step * (i);
                if (i % 2 == 0)
                {
                    Rezult+= step / 3 * 2 *findFunctionValue(x);
                }
                else
                {
                    Rezult += step / 3 * 4 * findFunctionValue(x);
                }
            }
            int tmpNumOfInterval = numOfInterval;
            double LastRezult = Rezult;
            Rezult *= 2;
            while (Math.Abs(Rezult - LastRezult) / (Math.Pow(2, k) - 1) >= ErrorRate)
            {
                LastRezult = Rezult;
                tmpNumOfInterval *= 2;
                step = (EndInterval - StartInterval) / (tmpNumOfInterval);
                Rezult = step / 3 * findFunctionValue(StartInterval);
                for (int i = 1; i < tmpNumOfInterval; i++)
                {
                    double x = StartInterval + step * (i);
                    if (i % 2 == 0)
                    {
                        Rezult += step / 3 * 2 * findFunctionValue(x);
                    }
                    else
                    {
                        Rezult += step / 3 * 4 * findFunctionValue(x);
                    }
                }
            }
            rezult rez = new rezult();
            rez.value = Rezult;
            rez.ErrorRate = Math.Abs(Rezult - LastRezult) / (Math.Pow(2, k) - 1);
            return rez;
        }


    }
}
