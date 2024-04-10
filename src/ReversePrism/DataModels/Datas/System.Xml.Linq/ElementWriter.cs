using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Writer                                   0001865D6BE0 ModelClassType XmlWriter XmlWriter XmlWriter Pointer
    // 018 Resolver                                 00018667ECE0 ModelEnumType NamespaceResolver NamespaceResolver NamespaceResolver Int32
    public partial class ElementWriter : DataModel
    {
        public XmlWriter?                               Writer                                  { get; set; }
        public NamespaceResolver                        Resolver                                { get; set; }

        public static ElementWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ElementWriter() { Pointer= p0 };

            value.Writer                                    = GetObject<XmlWriter>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlWriter.FromPointer); // 02466BCB0380 0x10 Writer                      ( 0001865D6BE0 ModelClassType XmlWriter XmlWriter XmlWriter Pointer )
            value.Resolver                                  = (NamespaceResolver)GetInt32(new IntPtr(p + 0x018)); // 02466BCB03A0 0x18 Resolver                    ( 00018667ECE0 ModelEnumType NamespaceResolver NamespaceResolver NamespaceResolver Int32 )

            return value;
        }
    }
}
