using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 SeasonThemeColor                         000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer
    // 020 SubSeasonThemeColor                      000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer
    public partial class ProduceSeasonThemeColorData
    {
        public List<Color>?                             SeasonThemeColor                        { get; set; }
        public List<Color>?                             SubSeasonThemeColor                     { get; set; }

        public static ProduceSeasonThemeColorData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSeasonThemeColorData();

            value.SeasonThemeColor                          = GetEnumList<Color>(new IntPtr(p + 0x018)); // 0270DA21B9C0 0x18 SeasonThemeColor            ( 000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.SubSeasonThemeColor                       = GetEnumList<Color>(new IntPtr(p + 0x020)); // 0270DA21B9E0 0x20 SubSeasonThemeColor         ( 000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer )

            return value;
        }
    }
}
