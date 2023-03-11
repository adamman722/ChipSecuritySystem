using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipSecuritySystem
{
    class Program
    {
        static void Main(string[] args)
        {


            // sooo I was not entirely sure what it meant by use the most chips but I was able to kinda create a random set of data to test and it works.
            //I would love some feedback becasue I know there has to be a better way that I am just not thinking of at the moment
            //not gonna lie my brain is fried from the past week haha
            List<ColorChip> colorChips = new List<ColorChip>() {new ColorChip(Color.Blue,Color.Yellow) ,new ColorChip(Color.Orange, Color.Yellow),new ColorChip(Color.Yellow, Color.Orange),new ColorChip(Color.Orange, Color.Red),new ColorChip(Color.Orange, Color.Red),new ColorChip(Color.Orange, Color.Red),new ColorChip(Color.Orange, Color.Red),new ColorChip(Color.Red, Color.Green),new ColorChip(Color.Yellow, Color.Orange),new ColorChip(Color.Yellow, Color.Orange),new ColorChip(Color.Yellow, Color.Orange),new ColorChip(Color.Yellow, Color.Orange),
                new ColorChip(Color.Orange, Color.Purple) };

            List<ColorChip> origianlData = colorChips;

            List<ColorChip> sortedList = new List<ColorChip>();
                ColorChip endChip = null;

            sortFunction2(colorChips);

            if (sortedList.Last().EndColor == Color.Green )
            {
                foreach (var item in sortedList)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(true);
                Console.ReadLine();
            }
            else
            {
                foreach (var item in sortedList)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(false);
                Console.ReadLine();
            }
  

            List<ColorChip> sortFunction2(List<ColorChip> colorChips1, List<ColorChip> colorChips2 = null , ColorChip endingChip = null)
            {
                int chipCount = sortedList.Count - 1;

                if (colorChips1.Count == 0)
                {
                    return colorChips2;
                }
                foreach (var item in colorChips1)
                {
                    if (item.EndColor == Color.Green && endingChip == null)
                    {
                        endChip = item;
                    }
                }
                foreach (var item in colorChips1)
                {

                    if (sortedList.Count == 0 && item.StartColor == Color.Blue && item.EndColor == Color.Green)
                    {
                        sortedList.Add(item);
                        break;
                    }
                    if (sortedList.Count == 0 && item.StartColor == Color.Blue)
                    {
                        sortedList.Add(item);
                        colorChips1.Remove(item);
                        sortFunction2(colorChips1, sortedList);
                        return colorChips2;
                    }
                    if (sortedList[chipCount].EndColor == item.StartColor && item.EndColor == Color.Green)
                    {
                        sortedList.Add(item);
                        colorChips1.Remove(item);
                        return colorChips2;

                    }
                    if (sortedList[chipCount].EndColor == item.StartColor && item.EndColor == endChip.StartColor)
                    {
                        sortedList.Add(item);
                        colorChips1.Remove(item);
                        sortFunction2(colorChips1, sortedList);
                        return colorChips2;
                    }
                    if (sortedList[chipCount].EndColor == item.StartColor)
                    {
                        sortedList.Add(item);
                        colorChips1.Remove(item);
                        sortFunction2(colorChips1, sortedList);
                        return colorChips2;
                    }

                }
                return colorChips2;
            }
        }
    }
}

