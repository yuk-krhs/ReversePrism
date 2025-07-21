using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IntegrationNameArea                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ParentObject                             ModelClassType GameObject GameObject GameObject Pointer
    // 030 ChildObjectBase                          ModelClassType ProducePreparationIdolSkillSelectListItemContent ProducePreparationIdolSkillSelectListItemContent ProducePreparationIdolSkillSelectListItemContent Pointer
    // 038 onSelectedSkillSubject                   Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 040 Ct                                       ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 048 Vm                                       ModelClassType ProducePreparationIdolSkillSelectPopupViewModel ProducePreparationIdolSkillSelectPopupViewModel ProducePreparationIdolSkillSelectPopupViewModel Pointer
    // 050 ProducePreparationIdolSkillSelectListItemContentList ModelClassListType ProducePreparationIdolSkillSelectListItemContent[] ProducePreparationIdolSkillSelectListItemContent[] List<ProducePreparationIdolSkillSelectListItemContent> Pointer
    // 058 SelectIndex                              ModelPrimitiveType int int int Int32
    // 05C SelectedIndex                            ModelPrimitiveType int int int Int32
    // 060 SelectSkill                              ModelClassType IIdolSkillStatus IIdolSkillStatus IIdolSkillStatus Pointer
    // 068 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProducePreparationIdolSkillSelectPopupView : DataModel
    {
        public UITextMeshProUGUI?                       IntegrationNameArea                     { get; set; }
        public GameObject?                              ParentObject                            { get; set; }
        public ProducePreparationIdolSkillSelectListItemContent? ChildObjectBase                         { get; set; }
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

            value.IntegrationNameArea                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 IntegrationNameArea         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ParentObject                              = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 ParentObject                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ChildObjectBase                           = GetObject<ProducePreparationIdolSkillSelectListItemContent>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProducePreparationIdolSkillSelectListItemContent.FromPointer); // 0x30 ChildObjectBase             ( ModelClassType ProducePreparationIdolSkillSelectListItemContent ProducePreparationIdolSkillSelectListItemContent ProducePreparationIdolSkillSelectListItemContent Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x040)); // 0x40 Ct                          ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.Vm                                        = GetObject<ProducePreparationIdolSkillSelectPopupViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProducePreparationIdolSkillSelectPopupViewModel.FromPointer); // 0x48 Vm                          ( ModelClassType ProducePreparationIdolSkillSelectPopupViewModel ProducePreparationIdolSkillSelectPopupViewModel ProducePreparationIdolSkillSelectPopupViewModel Pointer )
            value.ProducePreparationIdolSkillSelectListItemContentList = GetObjectList<ProducePreparationIdolSkillSelectListItemContent>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProducePreparationIdolSkillSelectListItemContent.FromPointer); // 0x50 ProducePreparationIdolSkillSelectListItemContentList ( ModelClassListType ProducePreparationIdolSkillSelectListItemContent[] ProducePreparationIdolSkillSelectListItemContent[] List<ProducePreparationIdolSkillSelectListItemContent> Pointer )
            value.SelectIndex                               = GetInt32(new IntPtr(p + 0x058)); // 0x58 SelectIndex                 ( ModelPrimitiveType int int int Int32 )
            value.SelectedIndex                             = GetInt32(new IntPtr(p + 0x05C)); // 0x5C SelectedIndex               ( ModelPrimitiveType int int int Int32 )
            value.SelectSkill                               = GetObject<IIdolSkillStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IIdolSkillStatus.FromPointer); // 0x60 SelectSkill                 ( ModelClassType IIdolSkillStatus IIdolSkillStatus IIdolSkillStatus Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x068), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x68 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
