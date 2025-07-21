using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <unspecified>k__BackingField             FocusChangeDirection IL2CPP_TYPE_CLASS
    // 008 <none>k__BackingField                    FocusChangeDirection IL2CPP_TYPE_CLASS
    // 010 LastValue                                ModelClassType FocusChangeDirection FocusChangeDirection FocusChangeDirection Pointer
    // 010 M_Value                                  ModelPrimitiveType int int int Int32
    public partial class FocusChangeDirection : DataModel
    {
        public FocusChangeDirection?                    LastValue                               { get; set; }
        public int                                      M_Value                                 { get; set; }

        public static FocusChangeDirection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FocusChangeDirection() { Pointer= p0 };

            value.LastValue                                 = GetObject<FocusChangeDirection>(new IntPtr(p + 0x010), ReversePrism.DataModels.FocusChangeDirection.FromPointer); // 0x10 LastValue                   ( ModelClassType FocusChangeDirection FocusChangeDirection FocusChangeDirection Pointer )
            value.M_Value                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Value                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
