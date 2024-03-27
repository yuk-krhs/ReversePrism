using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _slots                                   Node<<var>>[] IL2CPP_TYPE_SZARRAY
    // 000 _slotMap                                 int[] IL2CPP_TYPE_SZARRAY
    // 000 _inUseCount                              int IL2CPP_TYPE_I4
    // 000 _pageId                                  int IL2CPP_TYPE_I4
    // 000 _nextFreeSlotLine                        int IL2CPP_TYPE_I4
    public partial class TreePage
    {

        public static TreePage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TreePage();


            return value;
        }
    }
}
