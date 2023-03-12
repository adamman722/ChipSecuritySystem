using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipSecuritySystem
{
    class Program
    {
        public class Dominoe
        {
            public Dominoe(int left, int right)
            {
                LeftSide = left;
                RightSide = right;
            }

            public int LeftSide;
            public int RightSide;
        }
        static void Main(string[] args)
        {

            // sooo I was not entirely sure what it meant by "use the most chips" but I was able to kinda create a random set of data to test and it works...sorta
            //I would love some feedback becasue I know there has to be a better way that I am just not thinking of at the moment.
            //not gonna lie my brain is fried from the past week haha.

            List<ColorChip> colorChips = new List<ColorChip>() {new ColorChip(Color.Orange, Color.Yellow),new ColorChip(Color.Yellow, Color.Orange),new ColorChip(Color.Orange, Color.Red),new ColorChip(Color.Red, Color.Yellow),new ColorChip(Color.Orange, Color.Red),new ColorChip(Color.Orange, Color.Red),new ColorChip(Color.Red, Color.Green),new ColorChip(Color.Blue, Color.Yellow),new ColorChip(Color.Yellow, Color.Orange),new ColorChip(Color.Yellow, Color.Orange),new ColorChip(Color.Yellow, Color.Orange),new ColorChip(Color.Yellow, Color.Orange),
                new ColorChip(Color.Orange, Color.Purple) };



            EntryPoint ep = new EntryPoint(colorChips);
            Tuple<string, List<ColorChip>> data = ep.DoesItLink();

            if (data.Item2 != null)
            {
                foreach (var item in data.Item2)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(data.Item1);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(data.Item1);
                Console.ReadLine();
            }


            //FindBlue fb = new FindBlue(colorChips);

            //List<ColorChip> colorChipsSorted = fb.FindBlueInList();

            //if (colorChipsSorted[0] == null)
            //{
            //    Console.WriteLine("Cannot be done there is no blue starting chip");
            //    Console.ReadLine();
            //}
            //else
            //{
            //FindGreen fg = new FindGreen(colorChipsSorted);
            //colorChipsSorted = fg.FindGreenInList();

            ////endtry point for function
            // if (colorChipsSorted.Last() == null)
            //{
            //    Console.WriteLine("Cannot be done there is no green ending chip");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    FindLinks fl = new FindLinks();
            //    fl.sortFunction2(colorChipsSorted);
            //    List<ColorChip> sorted = fl.ReturnSorted();

            //    if (sorted == null)
            //    {
            //        Console.WriteLine("Could not find matching links");
            //        Console.ReadLine();
            //    }
            //    else
            //    {

            //    foreach (var item in sorted)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine(true);
            //    Console.ReadLine();
            //    }

            //}

            //}

        }
    }
}

