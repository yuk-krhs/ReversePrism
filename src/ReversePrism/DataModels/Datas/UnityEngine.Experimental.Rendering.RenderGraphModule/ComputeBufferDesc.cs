using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Count                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Stride                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Type                                     0001865F6A60 ModelEnumType ComputeBufferType ComputeBufferType ComputeBufferType Int32
    // 020 Name                                     0001866722E0 ModelPrimitiveType string string string String
    public partial class ComputeBufferDesc
    {
        public int                                      Count                                   { get; set; }
        public int                                      Stride                                  { get; set; }
        public ComputeBufferType                        Type                                    { get; set; }
        public string                                   Name                                    { get; set; }

        public static ComputeBufferDesc? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ComputeBufferDesc();

            value.Count                                     = GetInt32(new IntPtr(p + 0x010)); // 0270D90B4870 0x10 Count                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Stride                                    = GetInt32(new IntPtr(p + 0x014)); // 0270D90B4890 0x14 Stride                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Type                                      = (ComputeBufferType)GetInt32(new IntPtr(p + 0x018)); // 0270D90B48B0 0x18 Type                        ( 0001865F6A60 ModelEnumType ComputeBufferType ComputeBufferType ComputeBufferType Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0270D90B48D0 0x20 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
