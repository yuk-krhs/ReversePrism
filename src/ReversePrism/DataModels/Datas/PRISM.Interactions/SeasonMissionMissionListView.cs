using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 missionListButtonSubject                 Subject`1<SeasonMissionMissionListViewModel> IL2CPP_TYPE_GENERICINST
    // 098 EmptyText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class SeasonMissionMissionListView
    {
        public UITextMeshProUGUI?                       EmptyText                               { get; set; }

        public static SeasonMissionMissionListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionMissionListView();

            value.EmptyText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBD1E9D8 0x98 EmptyText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
