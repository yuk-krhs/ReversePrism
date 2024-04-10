using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 eventBuffer                              IntPtr IL2CPP_TYPE_PTR
    // 018 EventCount                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C SizeInBytes                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 CapacityInBytes                          0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class NativeInputEventBuffer : DataModel
    {
        public int                                      EventCount                              { get; set; }
        public int                                      SizeInBytes                             { get; set; }
        public int                                      CapacityInBytes                         { get; set; }

        public static NativeInputEventBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeInputEventBuffer() { Pointer= p0 };

            value.EventCount                                = GetInt32(new IntPtr(p + 0x018)); // 0245A692D3E8 0x18 EventCount                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SizeInBytes                               = GetInt32(new IntPtr(p + 0x01C)); // 0245A692D408 0x1C SizeInBytes                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CapacityInBytes                           = GetInt32(new IntPtr(p + 0x020)); // 0245A692D428 0x20 CapacityInBytes             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
