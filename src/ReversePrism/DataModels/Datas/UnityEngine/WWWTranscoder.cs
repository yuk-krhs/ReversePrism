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
    // 010 UrlEscapeChar                            ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 UrlSpace                                 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 DataSpace                                ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 UrlForbidden                             ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 QpEscapeChar                             ModelPrimitiveType sbyte sbyte sbyte SByte
    // 038 QpSpace                                  ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 040 QpForbidden                              ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
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

            value.UrlEscapeChar                             = GetSByte(new IntPtr(p + 0x010)); // 0x10 UrlEscapeChar               ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.UrlSpace                                  = GetSByteList(new IntPtr(p + 0x018)); // 0x18 UrlSpace                    ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.DataSpace                                 = GetSByteList(new IntPtr(p + 0x020)); // 0x20 DataSpace                   ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.UrlForbidden                              = GetSByteList(new IntPtr(p + 0x028)); // 0x28 UrlForbidden                ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.QpEscapeChar                              = GetSByte(new IntPtr(p + 0x030)); // 0x30 QpEscapeChar                ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.QpSpace                                   = GetSByteList(new IntPtr(p + 0x038)); // 0x38 QpSpace                     ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.QpForbidden                               = GetSByteList(new IntPtr(p + 0x040)); // 0x40 QpForbidden                 ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
