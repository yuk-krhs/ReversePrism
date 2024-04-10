using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     000186580650 ModelEnumType XPathResultType XPathResultType XPathResultType Int32
    // 018 _val                                     <object> IL2CPP_TYPE_OBJECT
    public partial class Operand : DataModel
    {
        public XPathResultType                          Type                                    { get; set; }

        public static Operand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Operand() { Pointer= p0 };

            value.Type                                      = (XPathResultType)GetInt32(new IntPtr(p + 0x010)); // 024667692A00 0x10 Type                        ( 000186580650 ModelEnumType XPathResultType XPathResultType XPathResultType Int32 )

            return value;
        }
    }
}
