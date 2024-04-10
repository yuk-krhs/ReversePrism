using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Values                                 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class UxmlEnumeration : DataModel
    {
        public List<string>?                            M_Values                                { get; set; }

        public static UxmlEnumeration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UxmlEnumeration() { Pointer= p0 };

            value.M_Values                                  = GetStringList(new IntPtr(p + 0x010)); // 0245A6815628 0x10 M_Values                    ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
