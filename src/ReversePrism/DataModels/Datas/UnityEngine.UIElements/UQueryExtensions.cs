using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SingleElementEmptyQuery                  UQueryState`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 010 SingleElementNameQuery                   UQueryState`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 020 SingleElementClassQuery                  UQueryState`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 030 SingleElementNameAndClassQuery           UQueryState`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 040 SingleElementTypeQuery                   UQueryState`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 050 SingleElementTypeAndNameQuery            UQueryState`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 060 SingleElementTypeAndClassQuery           UQueryState`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 070 SingleElementTypeAndNameAndClassQuery    UQueryState`1<VisualElement> IL2CPP_TYPE_GENERICINST
    public partial class UQueryExtensions
    {

        public static UQueryExtensions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UQueryExtensions();


            return value;
        }
    }
}
