using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SeasonPassObj                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 LoginPassObj                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 ViewModel                                0001866C1CD0 ModelClassType HomeHeaderPassContentViewModel HomeHeaderPassContentViewModel HomeHeaderPassContentViewModel Pointer
    public partial class HomeHeaderPassContentView : DataModel
    {
        public GameObject?                              SeasonPassObj                           { get; set; }
        public GameObject?                              LoginPassObj                            { get; set; }
        public HomeHeaderPassContentViewModel?          ViewModel                               { get; set; }

        public static HomeHeaderPassContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeHeaderPassContentView() { Pointer= p0 };

            value.SeasonPassObj                             = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0246630F5EF8 0x20 SeasonPassObj               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LoginPassObj                              = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0246630F5F18 0x28 LoginPassObj                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ViewModel                                 = GetObject<HomeHeaderPassContentViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.HomeHeaderPassContentViewModel.FromPointer); // 0246630F5F38 0x30 ViewModel                   ( 0001866C1CD0 ModelClassType HomeHeaderPassContentViewModel HomeHeaderPassContentViewModel HomeHeaderPassContentViewModel Pointer )

            return value;
        }
    }
}
