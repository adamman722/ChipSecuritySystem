using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipSecuritySystem
{
    public class EntryPoint
    {
        private List<ColorChip> colorChips;

        public EntryPoint(List<ColorChip> colorChips)
        {
            this.colorChips = colorChips;
        }

        public Tuple<string, List<ColorChip>> DoesItLink()
        {
        FindBlue fb = new FindBlue(colorChips);

            List<ColorChip> colorChipsSorted = fb.FindBlueInList();
            if (colorChipsSorted[0] == null)
            {
                return new Tuple<string, List<ColorChip>>("Cannot be done there is no blue starting chip", null);
            }
            else
            {
                FindGreen fg = new FindGreen(colorChipsSorted);
                colorChipsSorted = fg.FindGreenInList();

                if (colorChipsSorted.Last() == null)
                {
                    return new Tuple<string, List<ColorChip>>("Cannot be done there is no green ending chip", null);
                }
                else
                {
                    FindLinks fl = new FindLinks();
                    fl.sortFunction2(colorChipsSorted);
                    List<ColorChip> sorted = fl.ReturnSorted();

                    if (sorted == null)
                    {
                        return new Tuple<string, List<ColorChip>>("Could not find matching links", null);
             
                    }
                    else
                    {

                        return new Tuple<string, List<ColorChip>>("true", sorted);
                    }

                }
            }
            }

    }
}
