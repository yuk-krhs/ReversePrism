using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 charStart                                IntPtr IL2CPP_TYPE_PTR
    // 018 charEnd                                  IntPtr IL2CPP_TYPE_PTR
    // 020 Encoder                                  00018672D1C0 ModelClassType EncoderNLS EncoderNLS EncoderNLS Pointer
    // 028 SetEncoder                               000186595210 ModelPrimitiveType bool bool bool Bool
    // 029 BUsedEncoder                             000186595210 ModelPrimitiveType bool bool bool Bool
    // 02A BFallingBack                             000186595210 ModelPrimitiveType bool bool bool Bool
    // 02C IRecursionCount                          0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class EncoderFallbackBuffer : DataModel
    {
        public EncoderNLS?                              Encoder                                 { get; set; }
        public bool                                     SetEncoder                              { get; set; }
        public bool                                     BUsedEncoder                            { get; set; }
        public bool                                     BFallingBack                            { get; set; }
        public int                                      IRecursionCount                         { get; set; }

        public static EncoderFallbackBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EncoderFallbackBuffer() { Pointer= p0 };

            value.Encoder                                   = GetObject<EncoderNLS>(new IntPtr(p + 0x020), ReversePrism.DataModels.EncoderNLS.FromPointer); // 024666BDAAE0 0x20 Encoder                     ( 00018672D1C0 ModelClassType EncoderNLS EncoderNLS EncoderNLS Pointer )
            value.SetEncoder                                = GetBool(new IntPtr(p + 0x028)); // 024666BDAB00 0x28 SetEncoder                  ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.BUsedEncoder                              = GetBool(new IntPtr(p + 0x029)); // 024666BDAB20 0x29 BUsedEncoder                ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.BFallingBack                              = GetBool(new IntPtr(p + 0x02A)); // 024666BDAB40 0x2A BFallingBack                ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.IRecursionCount                           = GetInt32(new IntPtr(p + 0x02C)); // 024666BDAB60 0x2C IRecursionCount             ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
