using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_SortingLayers                          SortingLayer[] IL2CPP_TYPE_SZARRAY
    // 008 <lights>k__BackingField                  List`1<Light2D> IL2CPP_TYPE_GENERICINST
    public partial class Light2DManager : DataModel
    {

        public static Light2DManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Light2DManager() { Pointer= p0 };


            return value;
        }
    }
}
