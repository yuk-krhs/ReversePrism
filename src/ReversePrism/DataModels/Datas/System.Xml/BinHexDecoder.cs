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
    // 024 HasHalfByteCached                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 025 CachedHalfByte                           00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class BinHexDecoder : DataModel
    {
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      StartIndex                              { get; set; }
        public int                                      CurIndex                                { get; set; }
        public int                                      EndIndex                                { get; set; }
        public bool                                     HasHalfByteCached                       { get; set; }
        public sbyte                                    CachedHalfByte                          { get; set; }

        public static BinHexDecoder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinHexDecoder() { Pointer= p0 };

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x010)); // 02466739A310 0x10 Buffer                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.StartIndex                                = GetInt32(new IntPtr(p + 0x018)); // 02466739A330 0x18 StartIndex                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurIndex                                  = GetInt32(new IntPtr(p + 0x01C)); // 02466739A350 0x1C CurIndex                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EndIndex                                  = GetInt32(new IntPtr(p + 0x020)); // 02466739A370 0x20 EndIndex                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HasHalfByteCached                         = GetBool(new IntPtr(p + 0x024)); // 02466739A390 0x24 HasHalfByteCached           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CachedHalfByte                            = GetSByte(new IntPtr(p + 0x025)); // 02466739A3B0 0x25 CachedHalfByte              ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
