using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 onSelectPlace                            Subject`1<ValueTuple`2<ButtonGoToType, string>> IL2CPP_TYPE_GENERICINST
    public partial class PlaceToGetCellListContext : DataModel
    {

        public static PlaceToGetCellListContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlaceToGetCellListContext() { Pointer= p0 };


            return value;
        }
    }
}
