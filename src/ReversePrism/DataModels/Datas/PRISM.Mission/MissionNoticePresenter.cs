using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType MissionNoticeView MissionNoticeView MissionNoticeView Pointer
    // 028 EndCallBack                              Action`1<MissionNoticePresenter> IL2CPP_TYPE_GENERICINST
    public partial class MissionNoticePresenter : DataModel
    {
        public MissionNoticeView?                       View                                    { get; set; }

        public static MissionNoticePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionNoticePresenter() { Pointer= p0 };

            value.View                                      = GetObject<MissionNoticeView>(new IntPtr(p + 0x020), ReversePrism.DataModels.MissionNoticeView.FromPointer); // 0x20 View                        ( ModelClassType MissionNoticeView MissionNoticeView MissionNoticeView Pointer )

            return value;
        }
    }
}
