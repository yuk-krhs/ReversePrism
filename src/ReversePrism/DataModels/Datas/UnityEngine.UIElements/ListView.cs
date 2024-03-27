using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 540 m_MakeItem                               Func`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 548 m_BindItem                               Action`2<VisualElement, int> IL2CPP_TYPE_GENERICINST
    // 550 <unbindItem>k__BackingField              Action`2<VisualElement, int> IL2CPP_TYPE_GENERICINST
    // 558 <destroyItem>k__BackingField             Action`1<VisualElement> IL2CPP_TYPE_GENERICINST
    public partial class ListView
    {

        public static ListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ListView();


            return value;
        }
    }
}
