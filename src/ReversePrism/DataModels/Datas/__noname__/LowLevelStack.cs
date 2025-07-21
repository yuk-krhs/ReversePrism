using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Arr                                      ModelEnumListType FormatParam[] FormatParam[] List<FormatParam> Pointer
    // 018 Count                                    ModelPrimitiveType int int int Int32
    public partial class LowLevelStack : DataModel
    {
        public List<FormatParam>?                       Arr                                     { get; set; }
        public int                                      Count                                   { get; set; }

        public static LowLevelStack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LowLevelStack() { Pointer= p0 };

            value.Arr                                       = GetEnumList<FormatParam>(new IntPtr(p + 0x010)); // 0x10 Arr                         ( ModelEnumListType FormatParam[] FormatParam[] List<FormatParam> Pointer )
            value.Count                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Count                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
