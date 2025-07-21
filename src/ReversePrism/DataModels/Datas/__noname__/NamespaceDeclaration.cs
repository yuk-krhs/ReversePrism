using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prefix                                   ModelPrimitiveType string string string String
    // 018 Ns                                       ModelClassType XNamespace XNamespace XNamespace Pointer
    // 020 Scope                                    ModelPrimitiveType int int int Int32
    // 028 Prev                                     ModelClassType NamespaceDeclaration NamespaceDeclaration NamespaceDeclaration Pointer
    public partial class NamespaceDeclaration : DataModel
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
            var value   = new NamespaceDeclaration() { Pointer= p0 };

            value.Prefix                                    = GetString(new IntPtr(p + 0x010)); // 0x10 Prefix                      ( ModelPrimitiveType string string string String )
            value.Ns                                        = GetObject<XNamespace>(new IntPtr(p + 0x018), ReversePrism.DataModels.XNamespace.FromPointer); // 0x18 Ns                          ( ModelClassType XNamespace XNamespace XNamespace Pointer )
            value.Scope                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 Scope                       ( ModelPrimitiveType int int int Int32 )
            value.Prev                                      = GetObject<NamespaceDeclaration>(new IntPtr(p + 0x028), ReversePrism.DataModels.NamespaceDeclaration.FromPointer); // 0x28 Prev                        ( ModelClassType NamespaceDeclaration NamespaceDeclaration NamespaceDeclaration Pointer )

            return value;
        }
    }
}
