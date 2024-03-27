using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prefix                                   0001866722E0 ModelPrimitiveType string string string String
    // 018 Ns                                       00018657B870 ModelClassType XNamespace XNamespace XNamespace Pointer
    // 020 Scope                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 Prev                                     000186770BC0 ModelClassType NamespaceDeclaration NamespaceDeclaration NamespaceDeclaration Pointer
    public partial class NamespaceDeclaration
    {
        public string                                   Prefix                                  { get; set; }
        public XNamespace?                              Ns                                      { get; set; }
        public int                                      Scope                                   { get; set; }
        public NamespaceDeclaration?                    Prev                                    { get; set; }

        public static NamespaceDeclaration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NamespaceDeclaration();

            value.Prefix                                    = GetString(new IntPtr(p + 0x010)); // 0270DBC416B0 0x10 Prefix                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Ns                                        = GetObject<XNamespace>(new IntPtr(p + 0x018), ReversePrism.DataModels.XNamespace.FromPointer); // 0270DBC416D0 0x18 Ns                          ( 00018657B870 ModelClassType XNamespace XNamespace XNamespace Pointer )
            value.Scope                                     = GetInt32(new IntPtr(p + 0x020)); // 0270DBC416F0 0x20 Scope                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Prev                                      = GetObject<NamespaceDeclaration>(new IntPtr(p + 0x028), ReversePrism.DataModels.NamespaceDeclaration.FromPointer); // 0270DBC41710 0x28 Prev                        ( 000186770BC0 ModelClassType NamespaceDeclaration NamespaceDeclaration NamespaceDeclaration Pointer )

            return value;
        }
    }
}
