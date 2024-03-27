using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Items                                    000185CBBF68 ModelEnumListType Item[] Item[] List<Item> Pointer
    public partial class HowToPlayPopupResourceConfig
    {
        public List<Item>?                              Items                                   { get; set; }

        public static HowToPlayPopupResourceConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HowToPlayPopupResourceConfig();

            value.Items                                     = GetEnumList<Item>(new IntPtr(p + 0x018)); // 0270D4C6D3D8 0x18 Items                       ( 000185CBBF68 ModelEnumListType Item[] Item[] List<Item> Pointer )

            return value;
        }
    }
}
