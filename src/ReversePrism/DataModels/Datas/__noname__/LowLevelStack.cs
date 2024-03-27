using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Arr                                      000185B86B70 ModelEnumListType FormatParam[] FormatParam[] List<FormatParam> Pointer
    // 018 Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LowLevelStack
    {
        public List<FormatParam>?                       Arr                                     { get; set; }
        public int                                      Count                                   { get; set; }

        public static LowLevelStack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LowLevelStack();

            value.Arr                                       = GetEnumList<FormatParam>(new IntPtr(p + 0x010)); // 0270D6AA07C8 0x10 Arr                         ( 000185B86B70 ModelEnumListType FormatParam[] FormatParam[] List<FormatParam> Pointer )
            value.Count                                     = GetInt32(new IntPtr(p + 0x018)); // 0270D6AA07E8 0x18 Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
