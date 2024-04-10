using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartPoint                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Depth                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Substring                                0001866722E0 ModelPrimitiveType string string string String
    public partial class TargetPart : DataModel
    {
        public int                                      StartPoint                              { get; set; }
        public int                                      Depth                                   { get; set; }
        public string                                   Substring                               { get; set; }

        public static TargetPart? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TargetPart() { Pointer= p0 };

            value.StartPoint                                = GetInt32(new IntPtr(p + 0x010)); // 024664BA56F0 0x10 StartPoint                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x014)); // 024664BA5710 0x14 Depth                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Substring                                 = GetString(new IntPtr(p + 0x018)); // 024664BA5730 0x18 Substring                   ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
