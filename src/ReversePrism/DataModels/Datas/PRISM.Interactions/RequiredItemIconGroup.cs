using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IconViews                                ModelClassListType RequiredItemIconView[] RequiredItemIconView[] List<RequiredItemIconView> Pointer
    public partial class RequiredItemIconGroup : DataModel
    {
        public List<RequiredItemIconView>?              IconViews                               { get; set; }

        public static RequiredItemIconGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequiredItemIconGroup() { Pointer= p0 };

            value.IconViews                                 = GetObjectList<RequiredItemIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.RequiredItemIconView.FromPointer); // 0x20 IconViews                   ( ModelClassListType RequiredItemIconView[] RequiredItemIconView[] List<RequiredItemIconView> Pointer )

            return value;
        }
    }
}
