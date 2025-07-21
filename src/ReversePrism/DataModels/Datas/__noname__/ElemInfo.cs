using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelEnumType QName QName QName Int32
    // 028 XmlLang                                  ModelPrimitiveType string string string String
    // 030 XmlSpace                                 ModelEnumType XmlSpace XmlSpace XmlSpace Int32
    // 034 XmlspacePreserve                         ModelPrimitiveType bool bool bool Bool
    // 038 Nsdecls                                  ModelClassType NamespaceDecl NamespaceDecl NamespaceDecl Pointer
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

            value.Name                                      = (QName)GetInt32(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelEnumType QName QName QName Int32 )
            value.XmlLang                                   = GetString(new IntPtr(p + 0x028)); // 0x28 XmlLang                     ( ModelPrimitiveType string string string String )
            value.XmlSpace                                  = (XmlSpace)GetInt32(new IntPtr(p + 0x030)); // 0x30 XmlSpace                    ( ModelEnumType XmlSpace XmlSpace XmlSpace Int32 )
            value.XmlspacePreserve                          = GetBool(new IntPtr(p + 0x034)); // 0x34 XmlspacePreserve            ( ModelPrimitiveType bool bool bool Bool )
            value.Nsdecls                                   = GetObject<NamespaceDecl>(new IntPtr(p + 0x038), ReversePrism.DataModels.NamespaceDecl.FromPointer); // 0x38 Nsdecls                     ( ModelClassType NamespaceDecl NamespaceDecl NamespaceDecl Pointer )

            return value;
        }
    }
}
