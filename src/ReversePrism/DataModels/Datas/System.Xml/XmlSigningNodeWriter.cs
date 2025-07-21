using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Writer                                   ModelClassType XmlNodeWriter XmlNodeWriter XmlNodeWriter Pointer
    // 018 SigningWriter                            ModelClassType XmlCanonicalWriter XmlCanonicalWriter XmlCanonicalWriter Pointer
    // 020 Chars                                    ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 Base64Chars                              ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Text                                     ModelPrimitiveType bool bool bool Bool
    public partial class XmlSigningNodeWriter : DataModel
    {
        public XmlNodeWriter?                           Writer                                  { get; set; }
        public XmlCanonicalWriter?                      SigningWriter                           { get; set; }
        public List<sbyte>?                             Chars                                   { get; set; }
        public List<sbyte>?                             Base64Chars                             { get; set; }
        public bool                                     Text                                    { get; set; }

        public static XmlSigningNodeWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSigningNodeWriter() { Pointer= p0 };

            value.Writer                                    = GetObject<XmlNodeWriter>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlNodeWriter.FromPointer); // 0x10 Writer                      ( ModelClassType XmlNodeWriter XmlNodeWriter XmlNodeWriter Pointer )
            value.SigningWriter                             = GetObject<XmlCanonicalWriter>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlCanonicalWriter.FromPointer); // 0x18 SigningWriter               ( ModelClassType XmlCanonicalWriter XmlCanonicalWriter XmlCanonicalWriter Pointer )
            value.Chars                                     = GetSByteList(new IntPtr(p + 0x020)); // 0x20 Chars                       ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Base64Chars                               = GetSByteList(new IntPtr(p + 0x028)); // 0x28 Base64Chars                 ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Text                                      = GetBool(new IntPtr(p + 0x030)); // 0x30 Text                        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
