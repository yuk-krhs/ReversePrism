using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Properties                               00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    public partial class DynamicPropertyCollection
    {
        public ArrayList?                               Properties                              { get; set; }

        public static DynamicPropertyCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DynamicPropertyCollection();

            value.Properties                                = GetObject<ArrayList>(new IntPtr(p + 0x010), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D6BB3200 0x10 Properties                  ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )

            return value;
        }
    }
}
