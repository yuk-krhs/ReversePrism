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
    // 024 HasHalfByteCached                        ModelPrimitiveType bool bool bool Bool
    // 025 CachedHalfByte                           ModelPrimitiveType sbyte sbyte sbyte SByte
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

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x010)); // 0x10 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.StartIndex                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 StartIndex                  ( ModelPrimitiveType int int int Int32 )
            value.CurIndex                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C CurIndex                    ( ModelPrimitiveType int int int Int32 )
            value.EndIndex                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 EndIndex                    ( ModelPrimitiveType int int int Int32 )
            value.HasHalfByteCached                         = GetBool(new IntPtr(p + 0x024)); // 0x24 HasHalfByteCached           ( ModelPrimitiveType bool bool bool Bool )
            value.CachedHalfByte                            = GetSByte(new IntPtr(p + 0x025)); // 0x25 CachedHalfByte              ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
