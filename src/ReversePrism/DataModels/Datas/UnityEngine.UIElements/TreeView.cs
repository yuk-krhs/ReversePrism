using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 4C0 m_MakeItem                               Func`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 4C8 m_BindItem                               Action`2<VisualElement, int> IL2CPP_TYPE_GENERICINST
    // 4D0 <unbindItem>k__BackingField              Action`2<VisualElement, int> IL2CPP_TYPE_GENERICINST
    // 4D8 <destroyItem>k__BackingField             Action`1<VisualElement> IL2CPP_TYPE_GENERICINST
    public partial class TreeView
    {

        public static TreeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TreeView();


            return value;
        }
    }
}
