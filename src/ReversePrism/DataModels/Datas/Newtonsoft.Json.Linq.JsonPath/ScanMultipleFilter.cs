using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Names                                    000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class ScanMultipleFilter
    {
        public List<string>?                            Names                                   { get; set; }

        public static ScanMultipleFilter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScanMultipleFilter();

            value.Names                                     = GetStringList(new IntPtr(p + 0x010)); // 0270D8864128 0x10 Names                       ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
