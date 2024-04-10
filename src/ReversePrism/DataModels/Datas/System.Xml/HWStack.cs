using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 stack                                    <object>[] IL2CPP_TYPE_SZARRAY
    // 018 GrowthRate                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Used                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Size                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 Limit                                    0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.GrowthRate                                = GetInt32(new IntPtr(p + 0x018)); // 0246674D2138 0x18 GrowthRate                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Used                                      = GetInt32(new IntPtr(p + 0x01C)); // 0246674D2158 0x1C Used                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Size                                      = GetInt32(new IntPtr(p + 0x020)); // 0246674D2178 0x20 Size                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Limit                                     = GetInt32(new IntPtr(p + 0x024)); // 0246674D2198 0x24 Limit                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
