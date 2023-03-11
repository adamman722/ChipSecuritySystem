using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipSecuritySystem
{
    internal class FindGreen
    {
        private List<ColorChip> chips { get; set; }
        private ColorChip lastChip;

        public FindGreen(List<ColorChip> chipIntake)
        {
            this.chips = chipIntake;
        }
        public List<ColorChip> FindGreenInList()
        {
            try
            {
                int chipCount = chips.Count;
                lastChip = chips.Find((ColorChip) => ColorChip.EndColor == Color.Green);
                chips.Remove(lastChip);
                chips.Add(lastChip);
              

                return chips;
            }
            catch (Exception e)
            {
                return null;
            }


        }
    }
}
