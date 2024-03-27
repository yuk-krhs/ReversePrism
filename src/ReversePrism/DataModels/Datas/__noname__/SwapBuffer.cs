using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RtMSAA                                   00018664B580 ModelClassType RTHandle RTHandle RTHandle Pointer
    // 018 RtResolve                                00018664B580 ModelClassType RTHandle RTHandle RTHandle Pointer
    // 020 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 028 Msaa                                     0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class SwapBuffer
    {
        public RTHandle?                                RtMSAA                                  { get; set; }
        public RTHandle?                                RtResolve                               { get; set; }
        public string                                   Name                                    { get; set; }
        public int                                      Msaa                                    { get; set; }

        public static SwapBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwapBuffer();

            value.RtMSAA                                    = GetObject<RTHandle>(new IntPtr(p + 0x010), ReversePrism.DataModels.RTHandle.FromPointer); // 0270D0AC3F60 0x10 RtMSAA                      ( 00018664B580 ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.RtResolve                                 = GetObject<RTHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.RTHandle.FromPointer); // 0270D0AC3F80 0x18 RtResolve                   ( 00018664B580 ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0270D0AC3FA0 0x20 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Msaa                                      = GetInt32(new IntPtr(p + 0x028)); // 0270D0AC3FC0 0x28 Msaa                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
