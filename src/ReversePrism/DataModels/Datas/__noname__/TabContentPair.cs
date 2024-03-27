using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Tab                                      00018662D810 ModelClassType MobileHeaderTab MobileHeaderTab MobileHeaderTab Pointer
    // 018 Content                                  0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    public partial class TabContentPair
    {
        public MobileHeaderTab?                         Tab                                     { get; set; }
        public GameObject?                              Content                                 { get; set; }

        public static TabContentPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TabContentPair();

            value.Tab                                       = GetObject<MobileHeaderTab>(new IntPtr(p + 0x010), ReversePrism.DataModels.MobileHeaderTab.FromPointer); // 0270DB11C668 0x10 Tab                         ( 00018662D810 ModelClassType MobileHeaderTab MobileHeaderTab MobileHeaderTab Pointer )
            value.Content                                   = GetObject<GameObject>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB11C688 0x18 Content                     ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
