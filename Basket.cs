using System;
using System.Collections.Generic;
using System.Text;

namespace midterm_pos_terminal
{
    public class Basket : ItemProperties
    {
        //public double total; - removing as Subtotal from ItemProperties can  be used
        public Basket()
        {

        }

        public Basket(Sides _side, HotMain _hotMain)
        {
            Name = $"{_hotMain.Name} with {_side.Name}";
            Subtotal = _hotMain.Price + 2.5; //changed total to Subtotal
        }
    }
}
