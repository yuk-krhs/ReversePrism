using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_default                                UTF32Encoding IL2CPP_TYPE_CLASS
    // 008 s_bigEndianDefault                       UTF32Encoding IL2CPP_TYPE_CLASS
    // 010 S_bigEndianPreamble                      000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 S_littleEndianPreamble                   000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 EmitUTF32ByteOrderMark                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 039 IsThrowException                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03A BigEndian                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class UTF32Encoding
    {
        public List<sbyte>?                             S_bigEndianPreamble                     { get; set; }
        public List<sbyte>?                             S_littleEndianPreamble                  { get; set; }
        public bool                                     EmitUTF32ByteOrderMark                  { get; set; }
        public bool                                     IsThrowException                        { get; set; }
        public bool                                     BigEndian                               { get; set; }

        public static UTF32Encoding? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UTF32Encoding();

            value.S_bigEndianPreamble                       = GetSByteList(new IntPtr(p + 0x010)); // 0270D0E95940 0x10 S_bigEndianPreamble         ( 000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.S_littleEndianPreamble                    = GetSByteList(new IntPtr(p + 0x018)); // 0270D0E95960 0x18 S_littleEndianPreamble      ( 000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.EmitUTF32ByteOrderMark                    = GetBool(new IntPtr(p + 0x038)); // 0270D0E95980 0x38 EmitUTF32ByteOrderMark      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsThrowException                          = GetBool(new IntPtr(p + 0x039)); // 0270D0E959A0 0x39 IsThrowException            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BigEndian                                 = GetBool(new IntPtr(p + 0x03A)); // 0270D0E959C0 0x3A BigEndian                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
