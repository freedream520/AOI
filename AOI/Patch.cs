using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOI
{
    public class Patch
    {
        public int row;
        public int col;
        public int im_number;

        public Patch(int col, int row, int i)
        {
            this.col = col;
            this.row = row;
            this.im_number = i;
        }
    }
}
