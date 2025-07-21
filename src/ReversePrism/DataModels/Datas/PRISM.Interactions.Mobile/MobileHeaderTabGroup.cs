using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabContentPairs                          ModelClassListType TabContentPair[] TabContentPair[] List<TabContentPair> Pointer
    // 028 onClickTabSubject                        Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class MobileHeaderTabGroup : DataModel
    {
        public List<TabContentPair>?                    TabContentPairs                         { get; set; }

        public static MobileHeaderTabGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileHeaderTabGroup() { Pointer= p0 };

            value.TabContentPairs                           = GetObjectList<TabContentPair>(new IntPtr(p + 0x020), ReversePrism.DataModels.TabContentPair.FromPointer); // 0x20 TabContentPairs             ( ModelClassListType TabContentPair[] TabContentPair[] List<TabContentPair> Pointer )

            return value;
        }
    }
}
