using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 FlatArrayIndex                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class XmlTypeMapMemberExpandable : DataModel
    {
        public int                                      FlatArrayIndex                          { get; set; }

        public static XmlTypeMapMemberExpandable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlTypeMapMemberExpandable() { Pointer= p0 };

            value.FlatArrayIndex                            = GetInt32(new IntPtr(p + 0x078)); // 0246675394F8 0x78 FlatArrayIndex              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
