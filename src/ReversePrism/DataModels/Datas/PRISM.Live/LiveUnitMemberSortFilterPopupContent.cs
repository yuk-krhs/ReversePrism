using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 SortFilterTabGroup                       0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 068 SortView                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 DisplayOrderToggleButtonGroup            000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 078 FilterView                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 OthersFilterToggleButtons                000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 088 ShowProduceIdolToggleButtonGroup         000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 090 CharacterFilterView                      00018659E2B0 ModelClassType CharacterFilterView CharacterFilterView CharacterFilterView Pointer
    // 098 LiveSkillAllToggleButton                 00018669D390 ModelClassType GroupToggleButton GroupToggleButton GroupToggleButton Pointer
    // 0A0 LiveSkillToggleButtons                   000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 0A8 FilterResetButton                        000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    public partial class LiveUnitMemberSortFilterPopupContent : DataModel
    {
        public UITabGroupEx?                            SortFilterTabGroup                      { get; set; }
        public GameObject?                              SortView                                { get; set; }
        public ToggleButtonGroup?                       DisplayOrderToggleButtonGroup           { get; set; }
        public GameObject?                              FilterView                              { get; set; }
        public List<ToggleButton>?                      OthersFilterToggleButtons               { get; set; }
        public ToggleButtonGroup?                       ShowProduceIdolToggleButtonGroup        { get; set; }
        public CharacterFilterView?                     CharacterFilterView                     { get; set; }
        public GroupToggleButton?                       LiveSkillAllToggleButton                { get; set; }
        public List<ToggleButton>?                      LiveSkillToggleButtons                  { get; set; }
        public ButtonBase?                              FilterResetButton                       { get; set; }

        public static LiveUnitMemberSortFilterPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitMemberSortFilterPopupContent() { Pointer= p0 };

            value.SortFilterTabGroup                        = GetObject<UITabGroupEx>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 024665329560 0x60 SortFilterTabGroup          ( 0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.SortView                                  = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 024665329580 0x68 SortView                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.DisplayOrderToggleButtonGroup             = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0246653295A0 0x70 DisplayOrderToggleButtonGroup ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.FilterView                                = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0246653295C0 0x78 FilterView                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.OthersFilterToggleButtons                 = GetObjectList<ToggleButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.ToggleButton.FromPointer); // 0246653295E0 0x80 OthersFilterToggleButtons   ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.ShowProduceIdolToggleButtonGroup          = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x088), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 024665329600 0x88 ShowProduceIdolToggleButtonGroup ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.CharacterFilterView                       = GetObject<CharacterFilterView>(new IntPtr(p + 0x090), ReversePrism.DataModels.CharacterFilterView.FromPointer); // 024665329620 0x90 CharacterFilterView         ( 00018659E2B0 ModelClassType CharacterFilterView CharacterFilterView CharacterFilterView Pointer )
            value.LiveSkillAllToggleButton                  = GetObject<GroupToggleButton>(new IntPtr(p + 0x098), ReversePrism.DataModels.GroupToggleButton.FromPointer); // 024665329640 0x98 LiveSkillAllToggleButton    ( 00018669D390 ModelClassType GroupToggleButton GroupToggleButton GroupToggleButton Pointer )
            value.LiveSkillToggleButtons                    = GetObjectList<ToggleButton>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ToggleButton.FromPointer); // 024665329660 0xA0 LiveSkillToggleButtons      ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.FilterResetButton                         = GetObject<ButtonBase>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ButtonBase.FromPointer); // 024665329680 0xA8 FilterResetButton           ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )

            return value;
        }
    }
}
