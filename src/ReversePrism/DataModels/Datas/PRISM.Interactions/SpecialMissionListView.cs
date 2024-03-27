using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 EmptyText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 missionButtonSubject                     Subject`1<SpecialMissionListViewModel> IL2CPP_TYPE_GENERICINST
    // 0A0 missionUnknownButtonSubject              Subject`1<SpecialMissionListViewModel> IL2CPP_TYPE_GENERICINST
    public partial class SpecialMissionListView
    {
        public UITextMeshProUGUI?                       EmptyText                               { get; set; }

        public static SpecialMissionListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionListView();

            value.EmptyText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBD67168 0x90 EmptyText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
