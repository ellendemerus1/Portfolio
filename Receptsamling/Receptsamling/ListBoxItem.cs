using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receptsamling
{
    public class ListBoxItem
    {
        public string Text;
        public int Value;

        public override string ToString()
        {
            return Text;
        }

        public ListBoxItem(string text, int value)
        {
            this.Text = text;
            this.Value = value;
        }
    }
}
