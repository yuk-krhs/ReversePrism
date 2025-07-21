using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 SortFilterTabGroup                       ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 068 SortView                                 ModelClassType GameObject GameObject GameObject Pointer
    // 070 DisplayOrderToggleButtonGroup            ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 078 FilterView                               ModelClassType GameObject GameObject GameObject Pointer
    // 080 OthersFilterToggleButtons                ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 088 ShowProduceIdolToggleButtonGroup         ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 090 CharacterFilterView                      ModelClassType CharacterFilterView CharacterFilterView CharacterFilterView Pointer
    // 098 LiveSkillAllToggleButton                 ModelClassType GroupToggleButton GroupToggleButton GroupToggleButton Pointer
    // 0A0 LiveSkillToggleButtons                   ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 0A8 FilterResetButton                        ModelClassType ButtonBase ButtonBase ButtonBase Pointer
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

            value.SortFilterTabGroup                        = GetObject<UITabGroupEx>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0x60 SortFilterTabGroup          ( ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.SortView                                  = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 SortView                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.DisplayOrderToggleButtonGroup             = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x70 DisplayOrderToggleButtonGroup ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.FilterView                                = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 FilterView                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.OthersFilterToggleButtons                 = GetObjectList<ToggleButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x80 OthersFilterToggleButtons   ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.ShowProduceIdolToggleButtonGroup          = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x088), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x88 ShowProduceIdolToggleButtonGroup ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.CharacterFilterView                       = GetObject<CharacterFilterView>(new IntPtr(p + 0x090), ReversePrism.DataModels.CharacterFilterView.FromPointer); // 0x90 CharacterFilterView         ( ModelClassType CharacterFilterView CharacterFilterView CharacterFilterView Pointer )
            value.LiveSkillAllToggleButton                  = GetObject<GroupToggleButton>(new IntPtr(p + 0x098), ReversePrism.DataModels.GroupToggleButton.FromPointer); // 0x98 LiveSkillAllToggleButton    ( ModelClassType GroupToggleButton GroupToggleButton GroupToggleButton Pointer )
            value.LiveSkillToggleButtons                    = GetObjectList<ToggleButton>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ToggleButton.FromPointer); // 0xA0 LiveSkillToggleButtons      ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.FilterResetButton                         = GetObject<ButtonBase>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ButtonBase.FromPointer); // 0xA8 FilterResetButton           ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )

            return value;
        }
    }
}
