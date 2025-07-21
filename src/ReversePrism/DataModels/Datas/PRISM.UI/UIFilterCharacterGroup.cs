using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleCheckBox                            ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 028 GroupCheckBoxes                          ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 030 OtherMemberBoxes                         ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 038 IlluminaMemberBoxes                      ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 040 LanticaMemberBoxes                       ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 048 CrimaxMemberBoxes                        ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 050 AlstMemberBoxes                          ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 058 StrayMemberBoxes                         ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 060 NocthillMemberBoxes                      ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 068 ShhisMemberBoxes                         ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 070 CometicMemberBoxes                       ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 078 onChangeSubject                          Subject`1<ValueTuple`2<int, bool>> IL2CPP_TYPE_GENERICINST
    // 080 unitTogglesAry                           ToggleButton[][] IL2CPP_TYPE_SZARRAY
    public partial class UIFilterCharacterGroup : DataModel
    {
        public ToggleButton?                            TitleCheckBox                           { get; set; }
        public List<ToggleButton>?                      GroupCheckBoxes                         { get; set; }
        public List<ToggleButton>?                      OtherMemberBoxes                        { get; set; }
        public List<ToggleButton>?                      IlluminaMemberBoxes                     { get; set; }
        public List<ToggleButton>?                      LanticaMemberBoxes                      { get; set; }
        public List<ToggleButton>?                      CrimaxMemberBoxes                       { get; set; }
        public List<ToggleButton>?                      AlstMemberBoxes                         { get; set; }
        public List<ToggleButton>?                      StrayMemberBoxes                        { get; set; }
        public List<ToggleButton>?                      NocthillMemberBoxes                     { get; set; }
        public List<ToggleButton>?                      ShhisMemberBoxes                        { get; set; }
        public List<ToggleButton>?                      CometicMemberBoxes                      { get; set; }

        public static UIFilterCharacterGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIFilterCharacterGroup() { Pointer= p0 };

            value.TitleCheckBox                             = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x20 TitleCheckBox               ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.GroupCheckBoxes                           = GetObjectList<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x28 GroupCheckBoxes             ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.OtherMemberBoxes                          = GetObjectList<ToggleButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x30 OtherMemberBoxes            ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.IlluminaMemberBoxes                       = GetObjectList<ToggleButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x38 IlluminaMemberBoxes         ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.LanticaMemberBoxes                        = GetObjectList<ToggleButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x40 LanticaMemberBoxes          ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.CrimaxMemberBoxes                         = GetObjectList<ToggleButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x48 CrimaxMemberBoxes           ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.AlstMemberBoxes                           = GetObjectList<ToggleButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x50 AlstMemberBoxes             ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.StrayMemberBoxes                          = GetObjectList<ToggleButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x58 StrayMemberBoxes            ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.NocthillMemberBoxes                       = GetObjectList<ToggleButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x60 NocthillMemberBoxes         ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.ShhisMemberBoxes                          = GetObjectList<ToggleButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x68 ShhisMemberBoxes            ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.CometicMemberBoxes                        = GetObjectList<ToggleButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x70 CometicMemberBoxes          ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )

            return value;
        }
    }
}
