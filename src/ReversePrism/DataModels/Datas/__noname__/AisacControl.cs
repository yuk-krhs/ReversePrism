using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType uint uint uint UInt32
    // 014 Value                                    ModelPrimitiveType float float float Single
    public partial class AisacControl : DataModel
    {
        public uint                                     Id                                      { get; set; }
        public float                                    Value                                   { get; set; }

        public static AisacControl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AisacControl() { Pointer= p0 };

            value.Id                                        = GetUInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType uint uint uint UInt32 )
            value.Value                                     = GetSingle(new IntPtr(p + 0x014)); // 0x14 Value                       ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
