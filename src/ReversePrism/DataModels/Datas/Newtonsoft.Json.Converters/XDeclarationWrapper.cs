using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Declaration                              000186574530 ModelClassType XDeclaration XDeclaration XDeclaration Pointer
    public partial class XDeclarationWrapper
    {
        public XDeclaration?                            Declaration                             { get; set; }

        public static XDeclarationWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XDeclarationWrapper();

            value.Declaration                               = GetObject<XDeclaration>(new IntPtr(p + 0x018), ReversePrism.DataModels.XDeclaration.FromPointer); // 0270D886D540 0x18 Declaration                 ( 000186574530 ModelClassType XDeclaration XDeclaration XDeclaration Pointer )

            return value;
        }
    }
}
