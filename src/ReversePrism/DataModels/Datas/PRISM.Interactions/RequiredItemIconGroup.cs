using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IconViews                                000185CA0FA8 ModelClassListType RequiredItemIconView[] RequiredItemIconView[] List<RequiredItemIconView> Pointer
    public partial class RequiredItemIconGroup
    {
        public List<RequiredItemIconView>?              IconViews                               { get; set; }

        public static RequiredItemIconGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequiredItemIconGroup();

            value.IconViews                                 = GetObjectList<RequiredItemIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.RequiredItemIconView.FromPointer); // 0270DA275AD8 0x20 IconViews                   ( 000185CA0FA8 ModelClassListType RequiredItemIconView[] RequiredItemIconView[] List<RequiredItemIconView> Pointer )

            return value;
        }
    }
}
