using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Title                                    ModelPrimitiveType string string string String
    // 020 Items                                    ModelEnumListType Item[] Item[] List<Item> Pointer
    public partial class HowToPlayPopupResourceConfig : DataModel
    {
        public string                                   Title                                   { get; set; }
        public List<Item>?                              Items                                   { get; set; }

        public static HowToPlayPopupResourceConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HowToPlayPopupResourceConfig() { Pointer= p0 };

            value.Title                                     = GetString(new IntPtr(p + 0x018)); // 0x18 Title                       ( ModelPrimitiveType string string string String )
            value.Items                                     = GetEnumList<Item>(new IntPtr(p + 0x020)); // 0x20 Items                       ( ModelEnumListType Item[] Item[] List<Item> Pointer )

            return value;
        }
    }
}
