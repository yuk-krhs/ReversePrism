using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseViewModel                            0001866985C0 ModelClassType AdvTitleViewModel AdvTitleViewModel AdvTitleViewModel Pointer
    // 018 UnitId                                   0001865F4260 ModelPrimitiveType int int int Int32
    public partial class UnitIconDisplayableAdvTitleViewModel
    {
        public AdvTitleViewModel?                       BaseViewModel                           { get; set; }
        public int                                      UnitId                                  { get; set; }

        public static UnitIconDisplayableAdvTitleViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitIconDisplayableAdvTitleViewModel();

            value.BaseViewModel                             = GetObject<AdvTitleViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.AdvTitleViewModel.FromPointer); // 0270D5DD3778 0x10 BaseViewModel               ( 0001866985C0 ModelClassType AdvTitleViewModel AdvTitleViewModel AdvTitleViewModel Pointer )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D5DD3798 0x18 UnitId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
