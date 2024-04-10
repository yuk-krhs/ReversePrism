using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001867406A0 ModelEnumType QName QName QName Int32
    // 028 XmlLang                                  0001866722E0 ModelPrimitiveType string string string String
    // 030 XmlSpace                                 0001865CA710 ModelEnumType XmlSpace XmlSpace XmlSpace Int32
    // 034 XmlspacePreserve                         000186595960 ModelPrimitiveType bool bool bool Bool
    // 038 Nsdecls                                  00018673F920 ModelClassType NamespaceDecl NamespaceDecl NamespaceDecl Pointer
    public partial class ElemInfo : DataModel
    {
        public QName                                    Name                                    { get; set; }
        public string                                   XmlLang                                 { get; set; }
        public XmlSpace                                 XmlSpace                                { get; set; }
        public bool                                     XmlspacePreserve                        { get; set; }
        public NamespaceDecl?                           Nsdecls                                 { get; set; }

        public static ElemInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ElemInfo() { Pointer= p0 };

            value.Name                                      = (QName)GetInt32(new IntPtr(p + 0x010)); // 02466739E898 0x10 Name                        ( 0001867406A0 ModelEnumType QName QName QName Int32 )
            value.XmlLang                                   = GetString(new IntPtr(p + 0x028)); // 02466739E8B8 0x28 XmlLang                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.XmlSpace                                  = (XmlSpace)GetInt32(new IntPtr(p + 0x030)); // 02466739E8D8 0x30 XmlSpace                    ( 0001865CA710 ModelEnumType XmlSpace XmlSpace XmlSpace Int32 )
            value.XmlspacePreserve                          = GetBool(new IntPtr(p + 0x034)); // 02466739E8F8 0x34 XmlspacePreserve            ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Nsdecls                                   = GetObject<NamespaceDecl>(new IntPtr(p + 0x038), ReversePrism.DataModels.NamespaceDecl.FromPointer); // 02466739E918 0x38 Nsdecls                     ( 00018673F920 ModelClassType NamespaceDecl NamespaceDecl NamespaceDecl Pointer )

            return value;
        }
    }
}
