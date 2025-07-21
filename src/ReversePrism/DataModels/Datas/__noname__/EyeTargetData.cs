using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartFrame                               ModelPrimitiveType int int int Int32
    // 014 Target                                   ModelEnumType Target Target Target Int32
    public partial class EyeTargetData : DataModel
    {
        public int                                      StartFrame                              { get; set; }
        public Target                                   Target                                  { get; set; }

        public static EyeTargetData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EyeTargetData() { Pointer= p0 };

            value.StartFrame                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 StartFrame                  ( ModelPrimitiveType int int int Int32 )
            value.Target                                    = (Target)GetInt32(new IntPtr(p + 0x014)); // 0x14 Target                      ( ModelEnumType Target Target Target Int32 )

            return value;
        }
    }
}
