using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Attribute                                000186733F80 ModelEnumType Token Token Token Int32
    // 018 BuildFunc                                000186753F40 ModelClassType XsdBuildFunction XsdBuildFunction XsdBuildFunction Pointer
    public partial class XsdAttributeEntry : DataModel
    {
        public Token                                    Attribute                               { get; set; }
        public XsdBuildFunction?                        BuildFunc                               { get; set; }

        public static XsdAttributeEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XsdAttributeEntry() { Pointer= p0 };

            value.Attribute                                 = (Token)GetInt32(new IntPtr(p + 0x010)); // 024667661480 0x10 Attribute                   ( 000186733F80 ModelEnumType Token Token Token Int32 )
            value.BuildFunc                                 = GetObject<XsdBuildFunction>(new IntPtr(p + 0x018), ReversePrism.DataModels.XsdBuildFunction.FromPointer); // 0246676614A0 0x18 BuildFunc                   ( 000186753F40 ModelClassType XsdBuildFunction XsdBuildFunction XsdBuildFunction Pointer )

            return value;
        }
    }
}
