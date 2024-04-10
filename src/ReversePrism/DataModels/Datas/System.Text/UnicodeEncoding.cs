using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_bigEndianDefault                       UnicodeEncoding IL2CPP_TYPE_CLASS
    // 008 s_littleEndianDefault                    UnicodeEncoding IL2CPP_TYPE_CLASS
    // 010 S_bigEndianPreamble                      000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 S_littleEndianPreamble                   000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 IsThrowException                         000186595210 ModelPrimitiveType bool bool bool Bool
    // 039 BigEndian                                000186595210 ModelPrimitiveType bool bool bool Bool
    // 03A ByteOrderMark                            000186595210 ModelPrimitiveType bool bool bool Bool
    // 020 HighLowPatternMask                       00018669C990 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class UnicodeEncoding : DataModel
    {
        public List<sbyte>?                             S_bigEndianPreamble                     { get; set; }
        public List<sbyte>?                             S_littleEndianPreamble                  { get; set; }
        public bool                                     IsThrowException                        { get; set; }
        public bool                                     BigEndian                               { get; set; }
        public bool                                     ByteOrderMark                           { get; set; }
        public ulong                                    HighLowPatternMask                      { get; set; }

        public static UnicodeEncoding? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnicodeEncoding() { Pointer= p0 };

            value.S_bigEndianPreamble                       = GetSByteList(new IntPtr(p + 0x010)); // 0245A41B8228 0x10 S_bigEndianPreamble         ( 000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.S_littleEndianPreamble                    = GetSByteList(new IntPtr(p + 0x018)); // 0245A41B8248 0x18 S_littleEndianPreamble      ( 000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.IsThrowException                          = GetBool(new IntPtr(p + 0x038)); // 0245A41B8268 0x38 IsThrowException            ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.BigEndian                                 = GetBool(new IntPtr(p + 0x039)); // 0245A41B8288 0x39 BigEndian                   ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.ByteOrderMark                             = GetBool(new IntPtr(p + 0x03A)); // 0245A41B82A8 0x3A ByteOrderMark               ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.HighLowPatternMask                        = GetUInt64(new IntPtr(p + 0x020)); // 0245A41B82C8 0x20 HighLowPatternMask          ( 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
