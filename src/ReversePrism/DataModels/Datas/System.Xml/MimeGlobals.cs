using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MimeVersionHeader                        string IL2CPP_TYPE_STRING
    // 008 DefaultVersion                           string IL2CPP_TYPE_STRING
    // 010 ContentIDScheme                          0001866727E0 ModelPrimitiveType string string string String
    // 018 ContentIDHeader                          0001866727E0 ModelPrimitiveType string string string String
    // 020 ContentTypeHeader                        0001866727E0 ModelPrimitiveType string string string String
    // 028 ContentTransferEncodingHeader            0001866727E0 ModelPrimitiveType string string string String
    // 030 EncodingBinary                           0001866727E0 ModelPrimitiveType string string string String
    // 038 Encoding8bit                             0001866727E0 ModelPrimitiveType string string string String
    // 040 COLONSPACE                               000185B79E70 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 048 DASHDASH                                 000185B79E70 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 050 CRLF                                     000185B79E70 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 058 BoundaryPrefix                           000185B79E70 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class MimeGlobals
    {
        public string                                   ContentIDScheme                         { get; set; }
        public string                                   ContentIDHeader                         { get; set; }
        public string                                   ContentTypeHeader                       { get; set; }
        public string                                   ContentTransferEncodingHeader           { get; set; }
        public string                                   EncodingBinary                          { get; set; }
        public string                                   Encoding8bit                            { get; set; }
        public List<sbyte>?                             COLONSPACE                              { get; set; }
        public List<sbyte>?                             DASHDASH                                { get; set; }
        public List<sbyte>?                             CRLF                                    { get; set; }
        public List<sbyte>?                             BoundaryPrefix                          { get; set; }

        public static MimeGlobals? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MimeGlobals();

            value.ContentIDScheme                           = GetString(new IntPtr(p + 0x010)); // 0270D7C9FBB8 0x10 ContentIDScheme             ( 0001866727E0 ModelPrimitiveType string string string String )
            value.ContentIDHeader                           = GetString(new IntPtr(p + 0x018)); // 0270D7C9FBD8 0x18 ContentIDHeader             ( 0001866727E0 ModelPrimitiveType string string string String )
            value.ContentTypeHeader                         = GetString(new IntPtr(p + 0x020)); // 0270D7C9FBF8 0x20 ContentTypeHeader           ( 0001866727E0 ModelPrimitiveType string string string String )
            value.ContentTransferEncodingHeader             = GetString(new IntPtr(p + 0x028)); // 0270D7C9FC18 0x28 ContentTransferEncodingHeader ( 0001866727E0 ModelPrimitiveType string string string String )
            value.EncodingBinary                            = GetString(new IntPtr(p + 0x030)); // 0270D7C9FC38 0x30 EncodingBinary              ( 0001866727E0 ModelPrimitiveType string string string String )
            value.Encoding8bit                              = GetString(new IntPtr(p + 0x038)); // 0270D7C9FC58 0x38 Encoding8bit                ( 0001866727E0 ModelPrimitiveType string string string String )
            value.COLONSPACE                                = GetSByteList(new IntPtr(p + 0x040)); // 0270D7C9FC78 0x40 COLONSPACE                  ( 000185B79E70 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.DASHDASH                                  = GetSByteList(new IntPtr(p + 0x048)); // 0270D7C9FC98 0x48 DASHDASH                    ( 000185B79E70 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.CRLF                                      = GetSByteList(new IntPtr(p + 0x050)); // 0270D7C9FCB8 0x50 CRLF                        ( 000185B79E70 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.BoundaryPrefix                            = GetSByteList(new IntPtr(p + 0x058)); // 0270D7C9FCD8 0x58 BoundaryPrefix              ( 000185B79E70 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
