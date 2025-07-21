using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Scope                                    ModelPrimitiveType int int int Int32
    // 018 Declaration                              ModelClassType NamespaceDeclaration NamespaceDeclaration NamespaceDeclaration Pointer
    // 020 Rover                                    ModelClassType NamespaceDeclaration NamespaceDeclaration NamespaceDeclaration Pointer
    public partial class NamespaceResolver : DataModel
    {
        public int                                      Scope                                   { get; set; }
        public NamespaceDeclaration?                    Declaration                             { get; set; }
        public NamespaceDeclaration?                    Rover                                   { get; set; }

        public static NamespaceResolver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NamespaceResolver() { Pointer= p0 };

            value.Scope                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Scope                       ( ModelPrimitiveType int int int Int32 )
            value.Declaration                               = GetObject<NamespaceDeclaration>(new IntPtr(p + 0x018), ReversePrism.DataModels.NamespaceDeclaration.FromPointer); // 0x18 Declaration                 ( ModelClassType NamespaceDeclaration NamespaceDeclaration NamespaceDeclaration Pointer )
            value.Rover                                     = GetObject<NamespaceDeclaration>(new IntPtr(p + 0x020), ReversePrism.DataModels.NamespaceDeclaration.FromPointer); // 0x20 Rover                       ( ModelClassType NamespaceDeclaration NamespaceDeclaration NamespaceDeclaration Pointer )

            return value;
        }
    }
}
