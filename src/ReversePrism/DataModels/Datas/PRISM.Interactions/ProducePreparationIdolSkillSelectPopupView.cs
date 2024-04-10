using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IntegrationNameArea                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ParentObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 ChildObjectBase                          00018656E130 ModelClassType ProducePreparationIdolSkillSelectListItemContent ProducePreparationIdolSkillSelectListItemContent ProducePreparationIdolSkillSelectListItemContent Pointer
    // 038 PIdolDetailPopupViewFactory              0001865CFB80 ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer
    // 040 onSelectedSkillSubject                   Subject`1<IProduceIdolStatus> IL2CPP_TYPE_GENERICINST
    // 048 Ct                                       00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 050 Vm                                       00018656FF80 ModelClassType ProducePreparationIdolSkillSelectPopupViewModel ProducePreparationIdolSkillSelectPopupViewModel ProducePreparationIdolSkillSelectPopupViewModel Pointer
    // 058 ProducePreparationIdolSkillSelectListItemContentList 000185B9D850 ModelClassListType ProducePreparationIdolSkillSelectListItemContent[] ProducePreparationIdolSkillSelectListItemContent[] List<ProducePreparationIdolSkillSelectListItemContent> Pointer
    // 060 SelectIndex                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 064 SelectedIndex                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 SelectSkill                              0001865780F0 ModelClassType IIdolSkillStatus IIdolSkillStatus IIdolSkillStatus Pointer
    // 070 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProducePreparationIdolSkillSelectPopupView : DataModel
    {
        public UITextMeshProUGUI?                       IntegrationNameArea                     { get; set; }
        public GameObject?                              ParentObject                            { get; set; }
        public ProducePreparationIdolSkillSelectListItemContent? ChildObjectBase                         { get; set; }
        public IPIdolDetailPopupViewFactory?            PIdolDetailPopupViewFactory             { get; set; }
        public CancellationToken                        Ct                                      { get; set; }
        public ProducePreparationIdolSkillSelectPopupViewModel? Vm                                      { get; set; }
        public List<ProducePreparationIdolSkillSelectListItemContent>? ProducePreparationIdolSkillSelectListItemContentList { get; set; }
        public int                                      SelectIndex                             { get; set; }
        public int                                      SelectedIndex                           { get; set; }
        public IIdolSkillStatus?                        SelectSkill                             { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProducePreparationIdolSkillSelectPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationIdolSkillSelectPopupView() { Pointer= p0 };

            value.IntegrationNameArea                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A178C20 0x20 IntegrationNameArea         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ParentObject                              = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466A178C40 0x28 ParentObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ChildObjectBase                           = GetObject<ProducePreparationIdolSkillSelectListItemContent>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProducePreparationIdolSkillSelectListItemContent.FromPointer); // 02466A178C60 0x30 ChildObjectBase             ( 00018656E130 ModelClassType ProducePreparationIdolSkillSelectListItemContent ProducePreparationIdolSkillSelectListItemContent ProducePreparationIdolSkillSelectListItemContent Pointer )
            value.PIdolDetailPopupViewFactory               = GetObject<IPIdolDetailPopupViewFactory>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPIdolDetailPopupViewFactory.FromPointer); // 02466A178C80 0x38 PIdolDetailPopupViewFactory ( 0001865CFB80 ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x048)); // 02466A178CC0 0x48 Ct                          ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.Vm                                        = GetObject<ProducePreparationIdolSkillSelectPopupViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProducePreparationIdolSkillSelectPopupViewModel.FromPointer); // 02466A178CE0 0x50 Vm                          ( 00018656FF80 ModelClassType ProducePreparationIdolSkillSelectPopupViewModel ProducePreparationIdolSkillSelectPopupViewModel ProducePreparationIdolSkillSelectPopupViewModel Pointer )
            value.ProducePreparationIdolSkillSelectListItemContentList = GetObjectList<ProducePreparationIdolSkillSelectListItemContent>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProducePreparationIdolSkillSelectListItemContent.FromPointer); // 02466A178D00 0x58 ProducePreparationIdolSkillSelectListItemContentList ( 000185B9D850 ModelClassListType ProducePreparationIdolSkillSelectListItemContent[] ProducePreparationIdolSkillSelectListItemContent[] List<ProducePreparationIdolSkillSelectListItemContent> Pointer )
            value.SelectIndex                               = GetInt32(new IntPtr(p + 0x060)); // 02466A178D20 0x60 SelectIndex                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectedIndex                             = GetInt32(new IntPtr(p + 0x064)); // 02466A178D40 0x64 SelectedIndex               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectSkill                               = GetObject<IIdolSkillStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.IIdolSkillStatus.FromPointer); // 02466A178D60 0x68 SelectSkill                 ( 0001865780F0 ModelClassType IIdolSkillStatus IIdolSkillStatus IIdolSkillStatus Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x070), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A178D80 0x70 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
