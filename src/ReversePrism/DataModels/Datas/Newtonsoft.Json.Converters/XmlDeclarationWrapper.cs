using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Declaration                              ModelClassType XmlDeclaration XmlDeclaration XmlDeclaration Pointer
    public partial class XmlDeclarationWrapper : DataModel
    {
        public XmlDeclaration?                          Declaration                             { get; set; }

        public static XmlDeclarationWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlDeclarationWrapper() { Pointer= p0 };

            value.Declaration                               = GetObject<XmlDeclaration>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlDeclaration.FromPointer); // 0x28 Declaration                 ( ModelClassType XmlDeclaration XmlDeclaration XmlDeclaration Pointer )

            return value;
        }
    }
}
