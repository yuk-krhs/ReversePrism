using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleCheckBox                            000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 028 GroupCheckBoxes                          000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 030 OtherMemberBoxes                         000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 038 IlluminaMemberBoxes                      000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 040 LanticaMemberBoxes                       000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 048 CrimaxMemberBoxes                        000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 050 AlstMemberBoxes                          000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 058 StrayMemberBoxes                         000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 060 NocthillMemberBoxes                      000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 068 ShhisMemberBoxes                         000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 070 CometicMemberBoxes                       000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 078 onChangeSubject                          Subject`1<ValueTuple`2<int, bool>> IL2CPP_TYPE_GENERICINST
    // 080 unitTogglesAry                           ToggleButton[][] IL2CPP_TYPE_SZARRAY
    public partial class UIFilterCharacterGroup
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
            var value   = new UIFilterCharacterGroup();

            value.TitleCheckBox                             = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D5486118 0x20 TitleCheckBox               ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.GroupCheckBoxes                           = GetObjectList<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D5486138 0x28 GroupCheckBoxes             ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.OtherMemberBoxes                          = GetObjectList<ToggleButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D5486158 0x30 OtherMemberBoxes            ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.IlluminaMemberBoxes                       = GetObjectList<ToggleButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D5486178 0x38 IlluminaMemberBoxes         ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.LanticaMemberBoxes                        = GetObjectList<ToggleButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D5486198 0x40 LanticaMemberBoxes          ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.CrimaxMemberBoxes                         = GetObjectList<ToggleButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D54861B8 0x48 CrimaxMemberBoxes           ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.AlstMemberBoxes                           = GetObjectList<ToggleButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D54861D8 0x50 AlstMemberBoxes             ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.StrayMemberBoxes                          = GetObjectList<ToggleButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D54861F8 0x58 StrayMemberBoxes            ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.NocthillMemberBoxes                       = GetObjectList<ToggleButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D5486218 0x60 NocthillMemberBoxes         ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.ShhisMemberBoxes                          = GetObjectList<ToggleButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D5486238 0x68 ShhisMemberBoxes            ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.CometicMemberBoxes                        = GetObjectList<ToggleButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D5486258 0x70 CometicMemberBoxes          ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )

            return value;
        }
    }
}
