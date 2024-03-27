using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 LevelColor                               000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer
    public partial class ProduceScheduleLevelColorData
    {
        public List<Color>?                             LevelColor                              { get; set; }

        public static ProduceScheduleLevelColorData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceScheduleLevelColorData();

            value.LevelColor                                = GetEnumList<Color>(new IntPtr(p + 0x018)); // 0270DA0CEE78 0x18 LevelColor                  ( 000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer )

            return value;
        }
    }
}
