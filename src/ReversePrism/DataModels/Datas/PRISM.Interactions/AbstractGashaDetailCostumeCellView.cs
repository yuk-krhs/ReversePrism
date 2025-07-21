using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class AbstractGashaDetailCostumeCellView : DataModel
    {

        public static AbstractGashaDetailCostumeCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AbstractGashaDetailCostumeCellView() { Pointer= p0 };


            return value;
        }
    }
}
