using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Model                                    000186704C60 ModelClassType DressUpRoomViewModel DressUpRoomViewModel DressUpRoomViewModel Pointer
    // 040 onApplied                                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class DressUpRoomCostumeChangePresenter
    {
        public DressUpRoomViewModel?                    Model                                   { get; set; }

        public static DressUpRoomCostumeChangePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomCostumeChangePresenter();

            value.Model                                     = GetObject<DressUpRoomViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.DressUpRoomViewModel.FromPointer); // 0270D6228A90 0x38 Model                       ( 000186704C60 ModelClassType DressUpRoomViewModel DressUpRoomViewModel DressUpRoomViewModel Pointer )

            return value;
        }
    }
}
