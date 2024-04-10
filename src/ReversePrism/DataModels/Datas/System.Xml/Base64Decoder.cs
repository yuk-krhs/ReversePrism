using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Buffer                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 StartIndex                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C CurIndex                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 EndIndex                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 Bits                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 BitsFilled                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CharsBase64                              string IL2CPP_TYPE_STRING
    // 008 MapBase64                                sbyte[] IL2CPP_TYPE_SZARRAY
    public partial class Base64Decoder : DataModel
    {
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      StartIndex                              { get; set; }
        public int                                      CurIndex                                { get; set; }
        public int                                      EndIndex                                { get; set; }
        public int                                      Bits                                    { get; set; }
        public int                                      BitsFilled                              { get; set; }

        public static Base64Decoder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Base64Decoder() { Pointer= p0 };

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x010)); // 024667397450 0x10 Buffer                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.StartIndex                                = GetInt32(new IntPtr(p + 0x018)); // 024667397470 0x18 StartIndex                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurIndex                                  = GetInt32(new IntPtr(p + 0x01C)); // 024667397490 0x1C CurIndex                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EndIndex                                  = GetInt32(new IntPtr(p + 0x020)); // 0246673974B0 0x20 EndIndex                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Bits                                      = GetInt32(new IntPtr(p + 0x024)); // 0246673974D0 0x24 Bits                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BitsFilled                                = GetInt32(new IntPtr(p + 0x028)); // 0246673974F0 0x28 BitsFilled                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
