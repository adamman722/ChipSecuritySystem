using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipSecuritySystem
{
    public class FindBlue
    {

        private List<ColorChip> chips { get; set; }
        private ColorChip firstChip;

        public FindBlue(List<ColorChip> chipIntake) { 
        this.chips = chipIntake;
        }


        public List<ColorChip> FindBlueInList()
        {
            try
            {

                firstChip =  chips.Find( (ColorChip) =>  ColorChip.StartColor == Color.Blue);
                chips.Remove(firstChip);
                chips.Insert(0, firstChip);

                return chips;
            }
            catch (Exception e)
            {
                return null;
            }


        }


    }
}
