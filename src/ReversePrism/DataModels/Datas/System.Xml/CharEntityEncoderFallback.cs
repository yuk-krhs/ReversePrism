using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FallbackBuffer                           000186595340 ModelClassType CharEntityEncoderFallbackBuffer CharEntityEncoderFallbackBuffer CharEntityEncoderFallbackBuffer Pointer
    // 018 TextContentMarks                         000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 EndMarkPos                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 CurMarkPos                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 StartOffset                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class CharEntityEncoderFallback
    {
        public CharEntityEncoderFallbackBuffer?         FallbackBuffer                          { get; set; }
        public List<int>?                               TextContentMarks                        { get; set; }
        public int                                      EndMarkPos                              { get; set; }
        public int                                      CurMarkPos                              { get; set; }
        public int                                      StartOffset                             { get; set; }

        public static CharEntityEncoderFallback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharEntityEncoderFallback();

            value.FallbackBuffer                            = GetObject<CharEntityEncoderFallbackBuffer>(new IntPtr(p + 0x010), ReversePrism.DataModels.CharEntityEncoderFallbackBuffer.FromPointer); // 0270D7368650 0x10 FallbackBuffer              ( 000186595340 ModelClassType CharEntityEncoderFallbackBuffer CharEntityEncoderFallbackBuffer CharEntityEncoderFallbackBuffer Pointer )
            value.TextContentMarks                          = GetInt32List(new IntPtr(p + 0x018)); // 0270D7368670 0x18 TextContentMarks            ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.EndMarkPos                                = GetInt32(new IntPtr(p + 0x020)); // 0270D7368690 0x20 EndMarkPos                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurMarkPos                                = GetInt32(new IntPtr(p + 0x024)); // 0270D73686B0 0x24 CurMarkPos                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StartOffset                               = GetInt32(new IntPtr(p + 0x028)); // 0270D73686D0 0x28 StartOffset                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
