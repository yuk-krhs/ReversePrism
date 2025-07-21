using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Buffer                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 StartIndex                               ModelPrimitiveType int int int Int32
    // 01C CurIndex                                 ModelPrimitiveType int int int Int32
    // 020 EndIndex                                 ModelPrimitiveType int int int Int32
    // 024 Bits                                     ModelPrimitiveType int int int Int32
    // 028 BitsFilled                               ModelPrimitiveType int int int Int32
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

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x010)); // 0x10 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.StartIndex                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 StartIndex                  ( ModelPrimitiveType int int int Int32 )
            value.CurIndex                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C CurIndex                    ( ModelPrimitiveType int int int Int32 )
            value.EndIndex                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 EndIndex                    ( ModelPrimitiveType int int int Int32 )
            value.Bits                                      = GetInt32(new IntPtr(p + 0x024)); // 0x24 Bits                        ( ModelPrimitiveType int int int Int32 )
            value.BitsFilled                                = GetInt32(new IntPtr(p + 0x028)); // 0x28 BitsFilled                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
