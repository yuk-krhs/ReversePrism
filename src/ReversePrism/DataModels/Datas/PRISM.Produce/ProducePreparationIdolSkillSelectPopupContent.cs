using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    // 060 IntegrationNameArea                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 ParentObject                             ModelClassType GameObject GameObject GameObject Pointer
    // 070 ChildObjectBase                          ModelClassType GameObject GameObject GameObject Pointer
    // 078 ProducePreparationIdolSkillSelectListItemContentList ModelClassListType List`1<ProducePreparationIdolSkillSelectListItemContent> List`1<ProducePreparationIdolSkillSelectListItemContent> List<ProducePreparationIdolSkillSelectListItemContent> Pointer
    // 080 SelectIndex                              ModelPrimitiveType int int int Int32
    // 084 SelectedIndex                            ModelPrimitiveType int int int Int32
    // 088 SelectSkill                              ModelClassType IIdolSkillStatus IIdolSkillStatus IIdolSkillStatus Pointer
    // 090 onSelectedSkillSubject                   Subject`1<IIdolSkillStatus> IL2CPP_TYPE_GENERICINST
    // 098 Ct                                       ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 0A0 IsProduce                                ModelPrimitiveType bool bool bool Bool
    // 0A8 CacheProduceIdol                         ModelClassType ProduceIdol ProduceIdol ProduceIdol Pointer
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

            value.IntegrationNameArea                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 IntegrationNameArea         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ParentObject                              = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 ParentObject                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ChildObjectBase                           = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 ChildObjectBase             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ProducePreparationIdolSkillSelectListItemContentList = GetObjectList<ProducePreparationIdolSkillSelectListItemContent>(new IntPtr(p + 0x078), ReversePrism.DataModels.ProducePreparationIdolSkillSelectListItemContent.FromPointer); // 0x78 ProducePreparationIdolSkillSelectListItemContentList ( ModelClassListType List`1<ProducePreparationIdolSkillSelectListItemContent> List`1<ProducePreparationIdolSkillSelectListItemContent> List<ProducePreparationIdolSkillSelectListItemContent> Pointer )
            value.SelectIndex                               = GetInt32(new IntPtr(p + 0x080)); // 0x80 SelectIndex                 ( ModelPrimitiveType int int int Int32 )
            value.SelectedIndex                             = GetInt32(new IntPtr(p + 0x084)); // 0x84 SelectedIndex               ( ModelPrimitiveType int int int Int32 )
            value.SelectSkill                               = GetObject<IIdolSkillStatus>(new IntPtr(p + 0x088), ReversePrism.DataModels.IIdolSkillStatus.FromPointer); // 0x88 SelectSkill                 ( ModelClassType IIdolSkillStatus IIdolSkillStatus IIdolSkillStatus Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x098)); // 0x98 Ct                          ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.IsProduce                                 = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 IsProduce                   ( ModelPrimitiveType bool bool bool Bool )
            value.CacheProduceIdol                          = GetObject<ProduceIdol>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ProduceIdol.FromPointer); // 0xA8 CacheProduceIdol            ( ModelClassType ProduceIdol ProduceIdol ProduceIdol Pointer )

            return value;
        }
    }
}
