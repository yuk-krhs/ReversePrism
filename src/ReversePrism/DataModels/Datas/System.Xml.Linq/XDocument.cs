using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Declaration                              000186574280 ModelClassType XDeclaration XDeclaration XDeclaration Pointer
    public partial class XDocument
    {
        public XDeclaration?                            Declaration                             { get; set; }

        public static XDocument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XDocument();

            value.Declaration                               = GetObject<XDeclaration>(new IntPtr(p + 0x030), ReversePrism.DataModels.XDeclaration.FromPointer); // 0270D86735C0 0x30 Declaration                 ( 000186574280 ModelClassType XDeclaration XDeclaration XDeclaration Pointer )

            return value;
        }
    }
}
