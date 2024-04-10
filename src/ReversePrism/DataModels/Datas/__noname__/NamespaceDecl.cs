using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prefix                                   0001866722E0 ModelPrimitiveType string string string String
    // 018 Uri                                      0001866722E0 ModelPrimitiveType string string string String
    // 020 ScopeLink                                00018673F920 ModelClassType NamespaceDecl NamespaceDecl NamespaceDecl Pointer
    // 028 PrevLink                                 00018673F920 ModelClassType NamespaceDecl NamespaceDecl NamespaceDecl Pointer
    // 030 Scope                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 Implied                                  000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class NamespaceDecl : DataModel
    {
        public string                                   Prefix                                  { get; set; }
        public string                                   Uri                                     { get; set; }
        public NamespaceDecl?                           ScopeLink                               { get; set; }
        public NamespaceDecl?                           PrevLink                                { get; set; }
        public int                                      Scope                                   { get; set; }
        public bool                                     Implied                                 { get; set; }

        public static NamespaceDecl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NamespaceDecl() { Pointer= p0 };

            value.Prefix                                    = GetString(new IntPtr(p + 0x010)); // 02466739EA78 0x10 Prefix                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Uri                                       = GetString(new IntPtr(p + 0x018)); // 02466739EA98 0x18 Uri                         ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ScopeLink                                 = GetObject<NamespaceDecl>(new IntPtr(p + 0x020), ReversePrism.DataModels.NamespaceDecl.FromPointer); // 02466739EAB8 0x20 ScopeLink                   ( 00018673F920 ModelClassType NamespaceDecl NamespaceDecl NamespaceDecl Pointer )
            value.PrevLink                                  = GetObject<NamespaceDecl>(new IntPtr(p + 0x028), ReversePrism.DataModels.NamespaceDecl.FromPointer); // 02466739EAD8 0x28 PrevLink                    ( 00018673F920 ModelClassType NamespaceDecl NamespaceDecl NamespaceDecl Pointer )
            value.Scope                                     = GetInt32(new IntPtr(p + 0x030)); // 02466739EAF8 0x30 Scope                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Implied                                   = GetBool(new IntPtr(p + 0x034)); // 02466739EB18 0x34 Implied                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
