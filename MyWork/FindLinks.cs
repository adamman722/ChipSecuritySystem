using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipSecuritySystem
{
    internal class FindLinks
    {

        List<ColorChip> sortedList = new List<ColorChip>();
        ColorChip endChip = null;

        public FindLinks() { }


     public  List<ColorChip> sortFunction2(List<ColorChip> colorChips1, List<ColorChip> colorChips2 = null, ColorChip endingChip = null)
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
                try
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
                catch (Exception e)
                {


                }
            }
            return sortedList;
        }

        public List<ColorChip> ReturnSorted() 
        {
            if (sortedList.FindLast((ColorChip => ColorChip.EndColor == Color.Green)) != null)
            {
                return sortedList;

            }
            else { return null; }

        }
    }
}
