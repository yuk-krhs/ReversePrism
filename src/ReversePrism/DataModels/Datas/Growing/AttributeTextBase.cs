using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 7D8 RootCanvas                               00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer
    // 7E0 ClickableEntries                         000185D1EEA8 ModelEnumListType List`1<ClickableEntry> List`1<ClickableEntry> List<ClickableEntry> Pointer
    public partial class AttributeTextBase
    {
        public Canvas?                                  RootCanvas                              { get; set; }
        public List<ClickableEntry>?                    ClickableEntries                        { get; set; }

        public static AttributeTextBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttributeTextBase();

            value.RootCanvas                                = GetObject<Canvas>(new IntPtr(p + 0x7D8), ReversePrism.DataModels.Canvas.FromPointer); // 0270D4B261C8 0x7D8 RootCanvas                  ( 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer )
            value.ClickableEntries                          = GetEnumList<ClickableEntry>(new IntPtr(p + 0x7E0)); // 0270D4B261E8 0x7E0 ClickableEntries            ( 000185D1EEA8 ModelEnumListType List`1<ClickableEntry> List`1<ClickableEntry> List<ClickableEntry> Pointer )

            return value;
        }
    }
}
