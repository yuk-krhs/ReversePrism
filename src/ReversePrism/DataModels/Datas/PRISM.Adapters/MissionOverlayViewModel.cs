using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 saveData                                 SavableJsonObject`1<MissionFilterSaveData> IL2CPP_TYPE_GENERICINST
    // 018 TabListViewModels                        ModelClassListType MissionOverlayTabListViewModel[] MissionOverlayTabListViewModel[] List<MissionOverlayTabListViewModel> Pointer
    // 020 CurrentTabIndex                          ModelPrimitiveType int int int Int32
    public partial class MissionOverlayViewModel : DataModel
    {
        public List<MissionOverlayTabListViewModel>?    TabListViewModels                       { get; set; }
        public int                                      CurrentTabIndex                         { get; set; }

        public static MissionOverlayViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionOverlayViewModel() { Pointer= p0 };

            value.TabListViewModels                         = GetObjectList<MissionOverlayTabListViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.MissionOverlayTabListViewModel.FromPointer); // 0x18 TabListViewModels           ( ModelClassListType MissionOverlayTabListViewModel[] MissionOverlayTabListViewModel[] List<MissionOverlayTabListViewModel> Pointer )
            value.CurrentTabIndex                           = GetInt32(new IntPtr(p + 0x020)); // 0x20 CurrentTabIndex             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
