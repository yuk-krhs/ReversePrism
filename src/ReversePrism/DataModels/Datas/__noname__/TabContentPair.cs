using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Tab                                      ModelClassType MobileHeaderTab MobileHeaderTab MobileHeaderTab Pointer
    // 018 Content                                  ModelClassType GameObject GameObject GameObject Pointer
    public partial class TabContentPair : DataModel
    {
        public MobileHeaderTab?                         Tab                                     { get; set; }
        public GameObject?                              Content                                 { get; set; }

        public static TabContentPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TabContentPair() { Pointer= p0 };

            value.Tab                                       = GetObject<MobileHeaderTab>(new IntPtr(p + 0x010), ReversePrism.DataModels.MobileHeaderTab.FromPointer); // 0x10 Tab                         ( ModelClassType MobileHeaderTab MobileHeaderTab MobileHeaderTab Pointer )
            value.Content                                   = GetObject<GameObject>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameObject.FromPointer); // 0x18 Content                     ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
