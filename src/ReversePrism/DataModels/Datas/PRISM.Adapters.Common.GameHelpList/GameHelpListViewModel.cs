using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OriginalCells                            ModelClassListType List`1<GameHelpListCellViewModel> List`1<GameHelpListCellViewModel> List<GameHelpListCellViewModel> Pointer
    // 018 CurrentShowCells                         ModelClassListType List`1<GameHelpListCellViewModel> List`1<GameHelpListCellViewModel> List<GameHelpListCellViewModel> Pointer
    // 020 expandedGroupIds                         HashSet`1<int> IL2CPP_TYPE_GENERICINST
    public partial class GameHelpListViewModel : DataModel
    {
        public List<GameHelpListCellViewModel>?         OriginalCells                           { get; set; }
        public List<GameHelpListCellViewModel>?         CurrentShowCells                        { get; set; }

        public static GameHelpListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GameHelpListViewModel() { Pointer= p0 };

            value.OriginalCells                             = GetObjectList<GameHelpListCellViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.GameHelpListCellViewModel.FromPointer); // 0x10 OriginalCells               ( ModelClassListType List`1<GameHelpListCellViewModel> List`1<GameHelpListCellViewModel> List<GameHelpListCellViewModel> Pointer )
            value.CurrentShowCells                          = GetObjectList<GameHelpListCellViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameHelpListCellViewModel.FromPointer); // 0x18 CurrentShowCells            ( ModelClassListType List`1<GameHelpListCellViewModel> List`1<GameHelpListCellViewModel> List<GameHelpListCellViewModel> Pointer )

            return value;
        }
    }
}
