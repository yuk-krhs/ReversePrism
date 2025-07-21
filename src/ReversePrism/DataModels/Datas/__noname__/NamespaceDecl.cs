using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prefix                                   ModelPrimitiveType string string string String
    // 018 Uri                                      ModelPrimitiveType string string string String
    // 020 ScopeLink                                ModelClassType NamespaceDecl NamespaceDecl NamespaceDecl Pointer
    // 028 PrevLink                                 ModelClassType NamespaceDecl NamespaceDecl NamespaceDecl Pointer
    // 030 Scope                                    ModelPrimitiveType int int int Int32
    // 034 Implied                                  ModelPrimitiveType bool bool bool Bool
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

            value.Prefix                                    = GetString(new IntPtr(p + 0x010)); // 0x10 Prefix                      ( ModelPrimitiveType string string string String )
            value.Uri                                       = GetString(new IntPtr(p + 0x018)); // 0x18 Uri                         ( ModelPrimitiveType string string string String )
            value.ScopeLink                                 = GetObject<NamespaceDecl>(new IntPtr(p + 0x020), ReversePrism.DataModels.NamespaceDecl.FromPointer); // 0x20 ScopeLink                   ( ModelClassType NamespaceDecl NamespaceDecl NamespaceDecl Pointer )
            value.PrevLink                                  = GetObject<NamespaceDecl>(new IntPtr(p + 0x028), ReversePrism.DataModels.NamespaceDecl.FromPointer); // 0x28 PrevLink                    ( ModelClassType NamespaceDecl NamespaceDecl NamespaceDecl Pointer )
            value.Scope                                     = GetInt32(new IntPtr(p + 0x030)); // 0x30 Scope                       ( ModelPrimitiveType int int int Int32 )
            value.Implied                                   = GetBool(new IntPtr(p + 0x034)); // 0x34 Implied                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
