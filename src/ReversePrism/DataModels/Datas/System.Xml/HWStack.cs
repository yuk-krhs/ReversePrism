using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 stack                                    <object>[] IL2CPP_TYPE_SZARRAY
    // 018 GrowthRate                               ModelPrimitiveType int int int Int32
    // 01C Used                                     ModelPrimitiveType int int int Int32
    // 020 Size                                     ModelPrimitiveType int int int Int32
    // 024 Limit                                    ModelPrimitiveType int int int Int32
    public partial class HWStack : DataModel
    {
        public int                                      GrowthRate                              { get; set; }
        public int                                      Used                                    { get; set; }
        public int                                      Size                                    { get; set; }
        public int                                      Limit                                   { get; set; }

        public static HWStack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HWStack() { Pointer= p0 };

            value.GrowthRate                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 GrowthRate                  ( ModelPrimitiveType int int int Int32 )
            value.Used                                      = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Used                        ( ModelPrimitiveType int int int Int32 )
            value.Size                                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 Size                        ( ModelPrimitiveType int int int Int32 )
            value.Limit                                     = GetInt32(new IntPtr(p + 0x024)); // 0x24 Limit                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
