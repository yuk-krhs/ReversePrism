using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CenterToggle                             ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 028 OnStageToggle                            ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 030 DuplicateToggle                          ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 038 IdolListView                             ModelClassType LimitedVoiceSeparateIdolListView LimitedVoiceSeparateIdolListView LimitedVoiceSeparateIdolListView Pointer
    // 040 SongNameLabel                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 CellModels                               ModelClassListType List`1<LimitedVoiceSeparateIdolListCellModel> List`1<LimitedVoiceSeparateIdolListCellModel> List<LimitedVoiceSeparateIdolListCellModel> Pointer
    // 058 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class LimitedVoiceSeparateDetailPopupView : DataModel
    {
        public ToggleButton?                            CenterToggle                            { get; set; }
        public ToggleButton?                            OnStageToggle                           { get; set; }
        public ToggleButton?                            DuplicateToggle                         { get; set; }
        public LimitedVoiceSeparateIdolListView?        IdolListView                            { get; set; }
        public UITextMeshProUGUI?                       SongNameLabel                           { get; set; }
        public List<LimitedVoiceSeparateIdolListCellModel>? CellModels                              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static LimitedVoiceSeparateDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LimitedVoiceSeparateDetailPopupView() { Pointer= p0 };

            value.CenterToggle                              = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x20 CenterToggle                ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.OnStageToggle                             = GetObject<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x28 OnStageToggle               ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.DuplicateToggle                           = GetObject<ToggleButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x30 DuplicateToggle             ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.IdolListView                              = GetObject<LimitedVoiceSeparateIdolListView>(new IntPtr(p + 0x038), ReversePrism.DataModels.LimitedVoiceSeparateIdolListView.FromPointer); // 0x38 IdolListView                ( ModelClassType LimitedVoiceSeparateIdolListView LimitedVoiceSeparateIdolListView LimitedVoiceSeparateIdolListView Pointer )
            value.SongNameLabel                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 SongNameLabel               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CellModels                                = GetObjectList<LimitedVoiceSeparateIdolListCellModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.LimitedVoiceSeparateIdolListCellModel.FromPointer); // 0x50 CellModels                  ( ModelClassListType List`1<LimitedVoiceSeparateIdolListCellModel> List`1<LimitedVoiceSeparateIdolListCellModel> List<LimitedVoiceSeparateIdolListCellModel> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x58 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
