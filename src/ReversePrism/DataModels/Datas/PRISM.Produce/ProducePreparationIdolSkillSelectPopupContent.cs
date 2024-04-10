using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    // 060 IntegrationNameArea                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 ParentObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 ChildObjectBase                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 ProducePreparationIdolSkillSelectListItemContentList 000185CFCA38 ModelClassListType List`1<ProducePreparationIdolSkillSelectListItemContent> List`1<ProducePreparationIdolSkillSelectListItemContent> List<ProducePreparationIdolSkillSelectListItemContent> Pointer
    // 080 SelectIndex                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 084 SelectedIndex                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 088 SelectSkill                              0001865780F0 ModelClassType IIdolSkillStatus IIdolSkillStatus IIdolSkillStatus Pointer
    // 090 onSelectedSkillSubject                   Subject`1<IIdolSkillStatus> IL2CPP_TYPE_GENERICINST
    // 098 Ct                                       00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 0A0 IsProduce                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A8 CacheProduceIdol                         0001865467F0 ModelClassType ProduceIdol ProduceIdol ProduceIdol Pointer
    public partial class ProducePreparationIdolSkillSelectPopupContent : DataModel
    {
        public UITextMeshProUGUI?                       IntegrationNameArea                     { get; set; }
        public GameObject?                              ParentObject                            { get; set; }
        public GameObject?                              ChildObjectBase                         { get; set; }
        public List<ProducePreparationIdolSkillSelectListItemContent>? ProducePreparationIdolSkillSelectListItemContentList { get; set; }
        public int                                      SelectIndex                             { get; set; }
        public int                                      SelectedIndex                           { get; set; }
        public IIdolSkillStatus?                        SelectSkill                             { get; set; }
        public CancellationToken                        Ct                                      { get; set; }
        public bool                                     IsProduce                               { get; set; }
        public ProduceIdol?                             CacheProduceIdol                        { get; set; }

        public static ProducePreparationIdolSkillSelectPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationIdolSkillSelectPopupContent() { Pointer= p0 };

            value.IntegrationNameArea                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665A8DF28 0x60 IntegrationNameArea         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ParentObject                              = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 024665A8DF48 0x68 ParentObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ChildObjectBase                           = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 024665A8DF68 0x70 ChildObjectBase             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ProducePreparationIdolSkillSelectListItemContentList = GetObjectList<ProducePreparationIdolSkillSelectListItemContent>(new IntPtr(p + 0x078), ReversePrism.DataModels.ProducePreparationIdolSkillSelectListItemContent.FromPointer); // 024665A8DF88 0x78 ProducePreparationIdolSkillSelectListItemContentList ( 000185CFCA38 ModelClassListType List`1<ProducePreparationIdolSkillSelectListItemContent> List`1<ProducePreparationIdolSkillSelectListItemContent> List<ProducePreparationIdolSkillSelectListItemContent> Pointer )
            value.SelectIndex                               = GetInt32(new IntPtr(p + 0x080)); // 024665A8DFA8 0x80 SelectIndex                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectedIndex                             = GetInt32(new IntPtr(p + 0x084)); // 024665A8DFC8 0x84 SelectedIndex               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectSkill                               = GetObject<IIdolSkillStatus>(new IntPtr(p + 0x088), ReversePrism.DataModels.IIdolSkillStatus.FromPointer); // 024665A8DFE8 0x88 SelectSkill                 ( 0001865780F0 ModelClassType IIdolSkillStatus IIdolSkillStatus IIdolSkillStatus Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x098)); // 024665A8E028 0x98 Ct                          ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.IsProduce                                 = GetBool(new IntPtr(p + 0x0A0)); // 024665A8E048 0xA0 IsProduce                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CacheProduceIdol                          = GetObject<ProduceIdol>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ProduceIdol.FromPointer); // 024665A8E068 0xA8 CacheProduceIdol            ( 0001865467F0 ModelClassType ProduceIdol ProduceIdol ProduceIdol Pointer )

            return value;
        }
    }
}
