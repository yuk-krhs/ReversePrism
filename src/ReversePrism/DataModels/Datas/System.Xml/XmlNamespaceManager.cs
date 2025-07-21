using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Nsdecls                                  ModelEnumListType NamespaceDeclaration[] NamespaceDeclaration[] List<NamespaceDeclaration> Pointer
    // 018 LastDecl                                 ModelPrimitiveType int int int Int32
    // 020 NameTable                                ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 028 ScopeId                                  ModelPrimitiveType int int int Int32
    // 030 hashTable                                Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 038 UseHashtable                             ModelPrimitiveType bool bool bool Bool
    // 040 Xml                                      ModelPrimitiveType string string string String
    // 048 XmlNs                                    ModelPrimitiveType string string string String
    public partial class XmlNamespaceManager : DataModel
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
            var value   = new XmlNamespaceManager() { Pointer= p0 };

            value.Nsdecls                                   = GetEnumList<NamespaceDeclaration>(new IntPtr(p + 0x010)); // 0x10 Nsdecls                     ( ModelEnumListType NamespaceDeclaration[] NamespaceDeclaration[] List<NamespaceDeclaration> Pointer )
            value.LastDecl                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 LastDecl                    ( ModelPrimitiveType int int int Int32 )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0x20 NameTable                   ( ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.ScopeId                                   = GetInt32(new IntPtr(p + 0x028)); // 0x28 ScopeId                     ( ModelPrimitiveType int int int Int32 )
            value.UseHashtable                              = GetBool(new IntPtr(p + 0x038)); // 0x38 UseHashtable                ( ModelPrimitiveType bool bool bool Bool )
            value.Xml                                       = GetString(new IntPtr(p + 0x040)); // 0x40 Xml                         ( ModelPrimitiveType string string string String )
            value.XmlNs                                     = GetString(new IntPtr(p + 0x048)); // 0x48 XmlNs                       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
