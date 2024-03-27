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
    // 010 XopIncludePrefix                         0001866727E0 ModelPrimitiveType string string string String
    // 018 XopIncludeHrefLocalName                  0001866727E0 ModelPrimitiveType string string string String
    // 020 XopIncludeHrefNamespace                  0001866727E0 ModelPrimitiveType string string string String
    // 028 MediaType                                0001866727E0 ModelPrimitiveType string string string String
    // 030 MediaSubtype                             0001866727E0 ModelPrimitiveType string string string String
    // 038 BoundaryParam                            0001866727E0 ModelPrimitiveType string string string String
    // 040 TypeParam                                0001866727E0 ModelPrimitiveType string string string String
    // 048 XopMediaType                             0001866727E0 ModelPrimitiveType string string string String
    // 050 XopMediaSubtype                          0001866727E0 ModelPrimitiveType string string string String
    // 058 XopType                                  0001866727E0 ModelPrimitiveType string string string String
    // 060 StartParam                               0001866727E0 ModelPrimitiveType string string string String
    // 068 StartInfoParam                           0001866727E0 ModelPrimitiveType string string string String
    // 070 ActionParam                              0001866727E0 ModelPrimitiveType string string string String
    // 078 CharsetParam                             0001866727E0 ModelPrimitiveType string string string String
    // 080 MimeContentTypeLocalName                 0001866727E0 ModelPrimitiveType string string string String
    // 088 MimeContentTypeNamespace200406           0001866727E0 ModelPrimitiveType string string string String
    // 090 MimeContentTypeNamespace200505           0001866727E0 ModelPrimitiveType string string string String
    // 098 DefaultContentTypeForBinary              0001866727E0 ModelPrimitiveType string string string String
    public partial class MtomGlobals
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
            var value   = new MtomGlobals();

            value.XopIncludePrefix                          = GetString(new IntPtr(p + 0x010)); // 0270D7C9F8D8 0x10 XopIncludePrefix            ( 0001866727E0 ModelPrimitiveType string string string String )
            value.XopIncludeHrefLocalName                   = GetString(new IntPtr(p + 0x018)); // 0270D7C9F8F8 0x18 XopIncludeHrefLocalName     ( 0001866727E0 ModelPrimitiveType string string string String )
            value.XopIncludeHrefNamespace                   = GetString(new IntPtr(p + 0x020)); // 0270D7C9F918 0x20 XopIncludeHrefNamespace     ( 0001866727E0 ModelPrimitiveType string string string String )
            value.MediaType                                 = GetString(new IntPtr(p + 0x028)); // 0270D7C9F938 0x28 MediaType                   ( 0001866727E0 ModelPrimitiveType string string string String )
            value.MediaSubtype                              = GetString(new IntPtr(p + 0x030)); // 0270D7C9F958 0x30 MediaSubtype                ( 0001866727E0 ModelPrimitiveType string string string String )
            value.BoundaryParam                             = GetString(new IntPtr(p + 0x038)); // 0270D7C9F978 0x38 BoundaryParam               ( 0001866727E0 ModelPrimitiveType string string string String )
            value.TypeParam                                 = GetString(new IntPtr(p + 0x040)); // 0270D7C9F998 0x40 TypeParam                   ( 0001866727E0 ModelPrimitiveType string string string String )
            value.XopMediaType                              = GetString(new IntPtr(p + 0x048)); // 0270D7C9F9B8 0x48 XopMediaType                ( 0001866727E0 ModelPrimitiveType string string string String )
            value.XopMediaSubtype                           = GetString(new IntPtr(p + 0x050)); // 0270D7C9F9D8 0x50 XopMediaSubtype             ( 0001866727E0 ModelPrimitiveType string string string String )
            value.XopType                                   = GetString(new IntPtr(p + 0x058)); // 0270D7C9F9F8 0x58 XopType                     ( 0001866727E0 ModelPrimitiveType string string string String )
            value.StartParam                                = GetString(new IntPtr(p + 0x060)); // 0270D7C9FA18 0x60 StartParam                  ( 0001866727E0 ModelPrimitiveType string string string String )
            value.StartInfoParam                            = GetString(new IntPtr(p + 0x068)); // 0270D7C9FA38 0x68 StartInfoParam              ( 0001866727E0 ModelPrimitiveType string string string String )
            value.ActionParam                               = GetString(new IntPtr(p + 0x070)); // 0270D7C9FA58 0x70 ActionParam                 ( 0001866727E0 ModelPrimitiveType string string string String )
            value.CharsetParam                              = GetString(new IntPtr(p + 0x078)); // 0270D7C9FA78 0x78 CharsetParam                ( 0001866727E0 ModelPrimitiveType string string string String )
            value.MimeContentTypeLocalName                  = GetString(new IntPtr(p + 0x080)); // 0270D7C9FA98 0x80 MimeContentTypeLocalName    ( 0001866727E0 ModelPrimitiveType string string string String )
            value.MimeContentTypeNamespace200406            = GetString(new IntPtr(p + 0x088)); // 0270D7C9FAB8 0x88 MimeContentTypeNamespace200406 ( 0001866727E0 ModelPrimitiveType string string string String )
            value.MimeContentTypeNamespace200505            = GetString(new IntPtr(p + 0x090)); // 0270D7C9FAD8 0x90 MimeContentTypeNamespace200505 ( 0001866727E0 ModelPrimitiveType string string string String )
            value.DefaultContentTypeForBinary               = GetString(new IntPtr(p + 0x098)); // 0270D7C9FAF8 0x98 DefaultContentTypeForBinary ( 0001866727E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
