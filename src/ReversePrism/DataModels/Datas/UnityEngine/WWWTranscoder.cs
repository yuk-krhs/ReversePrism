using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ucHexChars                               sbyte[] IL2CPP_TYPE_SZARRAY
    // 008 lcHexChars                               sbyte[] IL2CPP_TYPE_SZARRAY
    // 010 UrlEscapeChar                            00018659D190 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 UrlSpace                                 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 DataSpace                                000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 UrlForbidden                             000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 QpEscapeChar                             00018659D190 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 038 QpSpace                                  000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 040 QpForbidden                              000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class WWWTranscoder : DataModel
    {
        public sbyte                                    UrlEscapeChar                           { get; set; }
        public List<sbyte>?                             UrlSpace                                { get; set; }
        public List<sbyte>?                             DataSpace                               { get; set; }
        public List<sbyte>?                             UrlForbidden                            { get; set; }
        public sbyte                                    QpEscapeChar                            { get; set; }
        public List<sbyte>?                             QpSpace                                 { get; set; }
        public List<sbyte>?                             QpForbidden                             { get; set; }

        public static WWWTranscoder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WWWTranscoder() { Pointer= p0 };

            value.UrlEscapeChar                             = GetSByte(new IntPtr(p + 0x010)); // 0245A691C628 0x10 UrlEscapeChar               ( 00018659D190 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.UrlSpace                                  = GetSByteList(new IntPtr(p + 0x018)); // 0245A691C648 0x18 UrlSpace                    ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.DataSpace                                 = GetSByteList(new IntPtr(p + 0x020)); // 0245A691C668 0x20 DataSpace                   ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.UrlForbidden                              = GetSByteList(new IntPtr(p + 0x028)); // 0245A691C688 0x28 UrlForbidden                ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.QpEscapeChar                              = GetSByte(new IntPtr(p + 0x030)); // 0245A691C6A8 0x30 QpEscapeChar                ( 00018659D190 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.QpSpace                                   = GetSByteList(new IntPtr(p + 0x038)); // 0245A691C6C8 0x38 QpSpace                     ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.QpForbidden                               = GetSByteList(new IntPtr(p + 0x040)); // 0245A691C6E8 0x40 QpForbidden                 ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
