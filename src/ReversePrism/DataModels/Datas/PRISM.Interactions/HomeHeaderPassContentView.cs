using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SeasonPassObj                            ModelClassType GameObject GameObject GameObject Pointer
    // 028 LoginPassObj                             ModelClassType GameObject GameObject GameObject Pointer
    // 030 ViewModel                                ModelClassType HomeHeaderPassContentViewModel HomeHeaderPassContentViewModel HomeHeaderPassContentViewModel Pointer
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

            value.SeasonPassObj                             = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 SeasonPassObj               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LoginPassObj                              = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 LoginPassObj                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ViewModel                                 = GetObject<HomeHeaderPassContentViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.HomeHeaderPassContentViewModel.FromPointer); // 0x30 ViewModel                   ( ModelClassType HomeHeaderPassContentViewModel HomeHeaderPassContentViewModel HomeHeaderPassContentViewModel Pointer )

            return value;
        }
    }
}
