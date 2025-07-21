using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Count                                    ModelPrimitiveType int int int Int32
    // 014 Stride                                   ModelPrimitiveType int int int Int32
    // 018 Type                                     ModelEnumType ComputeBufferType ComputeBufferType ComputeBufferType Int32
    // 020 Name                                     ModelPrimitiveType string string string String
    public partial class ComputeBufferDesc : DataModel
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
            var value   = new ComputeBufferDesc() { Pointer= p0 };

            value.Count                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Count                       ( ModelPrimitiveType int int int Int32 )
            value.Stride                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 Stride                      ( ModelPrimitiveType int int int Int32 )
            value.Type                                      = (ComputeBufferType)GetInt32(new IntPtr(p + 0x018)); // 0x18 Type                        ( ModelEnumType ComputeBufferType ComputeBufferType ComputeBufferType Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
