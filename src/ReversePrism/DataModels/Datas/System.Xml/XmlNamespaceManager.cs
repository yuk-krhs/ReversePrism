using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Nsdecls                                  000185CC7748 ModelEnumListType NamespaceDeclaration[] NamespaceDeclaration[] List<NamespaceDeclaration> Pointer
    // 018 LastDecl                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 NameTable                                0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 028 ScopeId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 hashTable                                Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 038 UseHashtable                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 Xml                                      000186671910 ModelPrimitiveType string string string String
    // 048 XmlNs                                    000186671910 ModelPrimitiveType string string string String
    public partial class XmlNamespaceManager
    {
        public List<NamespaceDeclaration>?              Nsdecls                                 { get; set; }
        public int                                      LastDecl                                { get; set; }
        public XmlNameTable?                            NameTable                               { get; set; }
        public int                                      ScopeId                                 { get; set; }
        public bool                                     UseHashtable                            { get; set; }
        public string                                   Xml                                     { get; set; }
        public string                                   XmlNs                                   { get; set; }

        public static XmlNamespaceManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlNamespaceManager();

            value.Nsdecls                                   = GetEnumList<NamespaceDeclaration>(new IntPtr(p + 0x010)); // 0270D7383DC8 0x10 Nsdecls                     ( 000185CC7748 ModelEnumListType NamespaceDeclaration[] NamespaceDeclaration[] List<NamespaceDeclaration> Pointer )
            value.LastDecl                                  = GetInt32(new IntPtr(p + 0x018)); // 0270D7383DE8 0x18 LastDecl                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0270D7383E08 0x20 NameTable                   ( 0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.ScopeId                                   = GetInt32(new IntPtr(p + 0x028)); // 0270D7383E28 0x28 ScopeId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UseHashtable                              = GetBool(new IntPtr(p + 0x038)); // 0270D7383E68 0x38 UseHashtable                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Xml                                       = GetString(new IntPtr(p + 0x040)); // 0270D7383E88 0x40 Xml                         ( 000186671910 ModelPrimitiveType string string string String )
            value.XmlNs                                     = GetString(new IntPtr(p + 0x048)); // 0270D7383EA8 0x48 XmlNs                       ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
