using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Declaration                              ModelClassType XDeclaration XDeclaration XDeclaration Pointer
    public partial class XDeclarationWrapper : DataModel
    {
        public XDeclaration?                            Declaration                             { get; set; }

        public static XDeclarationWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XDeclarationWrapper() { Pointer= p0 };

            value.Declaration                               = GetObject<XDeclaration>(new IntPtr(p + 0x018), ReversePrism.DataModels.XDeclaration.FromPointer); // 0x18 Declaration                 ( ModelClassType XDeclaration XDeclaration XDeclaration Pointer )

            return value;
        }
    }
}
