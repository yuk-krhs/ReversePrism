using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 XopIncludeLocalName                      string IL2CPP_TYPE_STRING
    // 008 XopIncludeNamespace                      string IL2CPP_TYPE_STRING
    // 010 XopIncludePrefix                         ModelPrimitiveType string string string String
    // 018 XopIncludeHrefLocalName                  ModelPrimitiveType string string string String
    // 020 XopIncludeHrefNamespace                  ModelPrimitiveType string string string String
    // 028 MediaType                                ModelPrimitiveType string string string String
    // 030 MediaSubtype                             ModelPrimitiveType string string string String
    // 038 BoundaryParam                            ModelPrimitiveType string string string String
    // 040 TypeParam                                ModelPrimitiveType string string string String
    // 048 XopMediaType                             ModelPrimitiveType string string string String
    // 050 XopMediaSubtype                          ModelPrimitiveType string string string String
    // 058 XopType                                  ModelPrimitiveType string string string String
    // 060 StartParam                               ModelPrimitiveType string string string String
    // 068 StartInfoParam                           ModelPrimitiveType string string string String
    // 070 ActionParam                              ModelPrimitiveType string string string String
    // 078 CharsetParam                             ModelPrimitiveType string string string String
    // 080 MimeContentTypeLocalName                 ModelPrimitiveType string string string String
    // 088 MimeContentTypeNamespace200406           ModelPrimitiveType string string string String
    // 090 MimeContentTypeNamespace200505           ModelPrimitiveType string string string String
    // 098 DefaultContentTypeForBinary              ModelPrimitiveType string string string String
    public partial class MtomGlobals : DataModel
    {
        public string                                   XopIncludePrefix                        { get; set; }
        public string                                   XopIncludeHrefLocalName                 { get; set; }
        public string                                   XopIncludeHrefNamespace                 { get; set; }
        public string                                   MediaType                               { get; set; }
        public string                                   MediaSubtype                            { get; set; }
        public string                                   BoundaryParam                           { get; set; }
        public string                                   TypeParam                               { get; set; }
        public string                                   XopMediaType                            { get; set; }
        public string                                   XopMediaSubtype                         { get; set; }
        public string                                   XopType                                 { get; set; }
        public string                                   StartParam                              { get; set; }
        public string                                   StartInfoParam                          { get; set; }
        public string                                   ActionParam                             { get; set; }
        public string                                   CharsetParam                            { get; set; }
        public string                                   MimeContentTypeLocalName                { get; set; }
        public string                                   MimeContentTypeNamespace200406          { get; set; }
        public string                                   MimeContentTypeNamespace200505          { get; set; }
        public string                                   DefaultContentTypeForBinary             { get; set; }

        public static MtomGlobals? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MtomGlobals() { Pointer= p0 };

            value.XopIncludePrefix                          = GetString(new IntPtr(p + 0x010)); // 0x10 XopIncludePrefix            ( ModelPrimitiveType string string string String )
            value.XopIncludeHrefLocalName                   = GetString(new IntPtr(p + 0x018)); // 0x18 XopIncludeHrefLocalName     ( ModelPrimitiveType string string string String )
            value.XopIncludeHrefNamespace                   = GetString(new IntPtr(p + 0x020)); // 0x20 XopIncludeHrefNamespace     ( ModelPrimitiveType string string string String )
            value.MediaType                                 = GetString(new IntPtr(p + 0x028)); // 0x28 MediaType                   ( ModelPrimitiveType string string string String )
            value.MediaSubtype                              = GetString(new IntPtr(p + 0x030)); // 0x30 MediaSubtype                ( ModelPrimitiveType string string string String )
            value.BoundaryParam                             = GetString(new IntPtr(p + 0x038)); // 0x38 BoundaryParam               ( ModelPrimitiveType string string string String )
            value.TypeParam                                 = GetString(new IntPtr(p + 0x040)); // 0x40 TypeParam                   ( ModelPrimitiveType string string string String )
            value.XopMediaType                              = GetString(new IntPtr(p + 0x048)); // 0x48 XopMediaType                ( ModelPrimitiveType string string string String )
            value.XopMediaSubtype                           = GetString(new IntPtr(p + 0x050)); // 0x50 XopMediaSubtype             ( ModelPrimitiveType string string string String )
            value.XopType                                   = GetString(new IntPtr(p + 0x058)); // 0x58 XopType                     ( ModelPrimitiveType string string string String )
            value.StartParam                                = GetString(new IntPtr(p + 0x060)); // 0x60 StartParam                  ( ModelPrimitiveType string string string String )
            value.StartInfoParam                            = GetString(new IntPtr(p + 0x068)); // 0x68 StartInfoParam              ( ModelPrimitiveType string string string String )
            value.ActionParam                               = GetString(new IntPtr(p + 0x070)); // 0x70 ActionParam                 ( ModelPrimitiveType string string string String )
            value.CharsetParam                              = GetString(new IntPtr(p + 0x078)); // 0x78 CharsetParam                ( ModelPrimitiveType string string string String )
            value.MimeContentTypeLocalName                  = GetString(new IntPtr(p + 0x080)); // 0x80 MimeContentTypeLocalName    ( ModelPrimitiveType string string string String )
            value.MimeContentTypeNamespace200406            = GetString(new IntPtr(p + 0x088)); // 0x88 MimeContentTypeNamespace200406 ( ModelPrimitiveType string string string String )
            value.MimeContentTypeNamespace200505            = GetString(new IntPtr(p + 0x090)); // 0x90 MimeContentTypeNamespace200505 ( ModelPrimitiveType string string string String )
            value.DefaultContentTypeForBinary               = GetString(new IntPtr(p + 0x098)); // 0x98 DefaultContentTypeForBinary ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
