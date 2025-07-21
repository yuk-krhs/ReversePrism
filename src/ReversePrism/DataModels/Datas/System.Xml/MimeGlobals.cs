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
    // 010 ContentIDScheme                          ModelPrimitiveType string string string String
    // 018 ContentIDHeader                          ModelPrimitiveType string string string String
    // 020 ContentTypeHeader                        ModelPrimitiveType string string string String
    // 028 ContentTransferEncodingHeader            ModelPrimitiveType string string string String
    // 030 EncodingBinary                           ModelPrimitiveType string string string String
    // 038 Encoding8bit                             ModelPrimitiveType string string string String
    // 040 COLONSPACE                               ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 048 DASHDASH                                 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 050 CRLF                                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 058 BoundaryPrefix                           ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class MimeGlobals : DataModel
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
            var value   = new MimeGlobals() { Pointer= p0 };

            value.ContentIDScheme                           = GetString(new IntPtr(p + 0x010)); // 0x10 ContentIDScheme             ( ModelPrimitiveType string string string String )
            value.ContentIDHeader                           = GetString(new IntPtr(p + 0x018)); // 0x18 ContentIDHeader             ( ModelPrimitiveType string string string String )
            value.ContentTypeHeader                         = GetString(new IntPtr(p + 0x020)); // 0x20 ContentTypeHeader           ( ModelPrimitiveType string string string String )
            value.ContentTransferEncodingHeader             = GetString(new IntPtr(p + 0x028)); // 0x28 ContentTransferEncodingHeader ( ModelPrimitiveType string string string String )
            value.EncodingBinary                            = GetString(new IntPtr(p + 0x030)); // 0x30 EncodingBinary              ( ModelPrimitiveType string string string String )
            value.Encoding8bit                              = GetString(new IntPtr(p + 0x038)); // 0x38 Encoding8bit                ( ModelPrimitiveType string string string String )
            value.COLONSPACE                                = GetSByteList(new IntPtr(p + 0x040)); // 0x40 COLONSPACE                  ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.DASHDASH                                  = GetSByteList(new IntPtr(p + 0x048)); // 0x48 DASHDASH                    ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.CRLF                                      = GetSByteList(new IntPtr(p + 0x050)); // 0x50 CRLF                        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.BoundaryPrefix                            = GetSByteList(new IntPtr(p + 0x058)); // 0x58 BoundaryPrefix              ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
