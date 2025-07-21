using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 7D8 RootCanvas                               ModelClassType Canvas Canvas Canvas Pointer
    // 7E0 ClickableEntries                         ModelEnumListType List`1<ClickableEntry> List`1<ClickableEntry> List<ClickableEntry> Pointer
    public partial class AttributeTextBase : DataModel
    {
        public Canvas?                                  RootCanvas                              { get; set; }
        public List<ClickableEntry>?                    ClickableEntries                        { get; set; }

        public static AttributeTextBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttributeTextBase() { Pointer= p0 };

            value.RootCanvas                                = GetObject<Canvas>(new IntPtr(p + 0x7D8), ReversePrism.DataModels.Canvas.FromPointer); // 0x7D8 RootCanvas                  ( ModelClassType Canvas Canvas Canvas Pointer )
            value.ClickableEntries                          = GetEnumList<ClickableEntry>(new IntPtr(p + 0x7E0)); // 0x7E0 ClickableEntries            ( ModelEnumListType List`1<ClickableEntry> List`1<ClickableEntry> List<ClickableEntry> Pointer )

            return value;
        }
    }
}
