using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartFrame                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Target                                   00018667B9F0 ModelEnumType Target Target Target Int32
    public partial class EyeTargetData
    {
        public int                                      StartFrame                              { get; set; }
        public Target                                   Target                                  { get; set; }

        public static EyeTargetData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EyeTargetData();

            value.StartFrame                                = GetInt32(new IntPtr(p + 0x010)); // 0270D4D86050 0x10 StartFrame                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Target                                    = (Target)GetInt32(new IntPtr(p + 0x014)); // 0270D4D86070 0x14 Target                      ( 00018667B9F0 ModelEnumType Target Target Target Int32 )

            return value;
        }
    }
}
