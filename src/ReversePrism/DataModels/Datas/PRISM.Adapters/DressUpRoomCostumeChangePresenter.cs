using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Model                                    ModelClassType DressUpRoomViewModel DressUpRoomViewModel DressUpRoomViewModel Pointer
    // 038 onApplied                                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class DressUpRoomCostumeChangePresenter : DataModel
    {
        public DressUpRoomViewModel?                    Model                                   { get; set; }

        public static DressUpRoomCostumeChangePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomCostumeChangePresenter() { Pointer= p0 };

            value.Model                                     = GetObject<DressUpRoomViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.DressUpRoomViewModel.FromPointer); // 0x30 Model                       ( ModelClassType DressUpRoomViewModel DressUpRoomViewModel DressUpRoomViewModel Pointer )

            return value;
        }
    }
}
