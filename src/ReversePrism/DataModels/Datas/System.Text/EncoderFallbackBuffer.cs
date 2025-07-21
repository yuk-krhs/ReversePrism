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
    // 020 Encoder                                  ModelClassType EncoderNLS EncoderNLS EncoderNLS Pointer
    // 028 SetEncoder                               ModelPrimitiveType bool bool bool Bool
    // 029 BUsedEncoder                             ModelPrimitiveType bool bool bool Bool
    // 02A BFallingBack                             ModelPrimitiveType bool bool bool Bool
    // 02C IRecursionCount                          ModelPrimitiveType int int int Int32
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

            value.Encoder                                   = GetObject<EncoderNLS>(new IntPtr(p + 0x020), ReversePrism.DataModels.EncoderNLS.FromPointer); // 0x20 Encoder                     ( ModelClassType EncoderNLS EncoderNLS EncoderNLS Pointer )
            value.SetEncoder                                = GetBool(new IntPtr(p + 0x028)); // 0x28 SetEncoder                  ( ModelPrimitiveType bool bool bool Bool )
            value.BUsedEncoder                              = GetBool(new IntPtr(p + 0x029)); // 0x29 BUsedEncoder                ( ModelPrimitiveType bool bool bool Bool )
            value.BFallingBack                              = GetBool(new IntPtr(p + 0x02A)); // 0x2A BFallingBack                ( ModelPrimitiveType bool bool bool Bool )
            value.IRecursionCount                           = GetInt32(new IntPtr(p + 0x02C)); // 0x2C IRecursionCount             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
