using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Scope                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Declaration                              0001867709A0 ModelClassType NamespaceDeclaration NamespaceDeclaration NamespaceDeclaration Pointer
    // 020 Rover                                    0001867709A0 ModelClassType NamespaceDeclaration NamespaceDeclaration NamespaceDeclaration Pointer
    public partial class NamespaceResolver
    {
        public int                                      Scope                                   { get; set; }
        public NamespaceDeclaration?                    Declaration                             { get; set; }
        public NamespaceDeclaration?                    Rover                                   { get; set; }

        public static NamespaceResolver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NamespaceResolver();

            value.Scope                                     = GetInt32(new IntPtr(p + 0x010)); // 0270DBC41100 0x10 Scope                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Declaration                               = GetObject<NamespaceDeclaration>(new IntPtr(p + 0x018), ReversePrism.DataModels.NamespaceDeclaration.FromPointer); // 0270DBC41120 0x18 Declaration                 ( 0001867709A0 ModelClassType NamespaceDeclaration NamespaceDeclaration NamespaceDeclaration Pointer )
            value.Rover                                     = GetObject<NamespaceDeclaration>(new IntPtr(p + 0x020), ReversePrism.DataModels.NamespaceDeclaration.FromPointer); // 0270DBC41140 0x20 Rover                       ( 0001867709A0 ModelClassType NamespaceDeclaration NamespaceDeclaration NamespaceDeclaration Pointer )

            return value;
        }
    }
}
