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

            value.TitleCheckBox                             = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0246654F94F0 0x20 TitleCheckBox               ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.GroupCheckBoxes                           = GetObjectList<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0246654F9510 0x28 GroupCheckBoxes             ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.OtherMemberBoxes                          = GetObjectList<ToggleButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.ToggleButton.FromPointer); // 0246654F9530 0x30 OtherMemberBoxes            ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.IlluminaMemberBoxes                       = GetObjectList<ToggleButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.ToggleButton.FromPointer); // 0246654F9550 0x38 IlluminaMemberBoxes         ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.LanticaMemberBoxes                        = GetObjectList<ToggleButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.ToggleButton.FromPointer); // 0246654F9570 0x40 LanticaMemberBoxes          ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.CrimaxMemberBoxes                         = GetObjectList<ToggleButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.ToggleButton.FromPointer); // 0246654F9590 0x48 CrimaxMemberBoxes           ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.AlstMemberBoxes                           = GetObjectList<ToggleButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.ToggleButton.FromPointer); // 0246654F95B0 0x50 AlstMemberBoxes             ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.StrayMemberBoxes                          = GetObjectList<ToggleButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.ToggleButton.FromPointer); // 0246654F95D0 0x58 StrayMemberBoxes            ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.NocthillMemberBoxes                       = GetObjectList<ToggleButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.ToggleButton.FromPointer); // 0246654F95F0 0x60 NocthillMemberBoxes         ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.ShhisMemberBoxes                          = GetObjectList<ToggleButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.ToggleButton.FromPointer); // 0246654F9610 0x68 ShhisMemberBoxes            ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.CometicMemberBoxes                        = GetObjectList<ToggleButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.ToggleButton.FromPointer); // 0246654F9630 0x70 CometicMemberBoxes          ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )

            return value;
        }
    }
}
