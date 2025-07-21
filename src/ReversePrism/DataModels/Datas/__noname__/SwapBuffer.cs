using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RtMSAA                                   ModelClassType RTHandle RTHandle RTHandle Pointer
    // 018 RtResolve                                ModelClassType RTHandle RTHandle RTHandle Pointer
    // 020 Name                                     ModelPrimitiveType string string string String
    // 028 Msaa                                     ModelPrimitiveType int int int Int32
    public partial class SwapBuffer : DataModel
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
            var value   = new SwapBuffer() { Pointer= p0 };

            value.RtMSAA                                    = GetObject<RTHandle>(new IntPtr(p + 0x010), ReversePrism.DataModels.RTHandle.FromPointer); // 0x10 RtMSAA                      ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.RtResolve                                 = GetObject<RTHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.RTHandle.FromPointer); // 0x18 RtResolve                   ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )
            value.Msaa                                      = GetInt32(new IntPtr(p + 0x028)); // 0x28 Msaa                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
