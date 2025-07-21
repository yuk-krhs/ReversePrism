using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IdolSkillIconView                        ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 028 VoDaViMeMultiView                        ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer
    // 030 GoVoDaViMeMultiView                      ModelClassType GameObject GameObject GameObject Pointer
    // 038 IdolSkillNameText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 LockObject                               ModelClassType GameObject GameObject GameObject Pointer
    // 048 ReleaseRequirementObject                 ModelClassType GameObject GameObject GameObject Pointer
    // 050 ReleaseRequirementText                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ActiveObject                             ModelClassType GameObject GameObject GameObject Pointer
    // 060 SelectedButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 068 BlockObject                              ModelClassType GameObject GameObject GameObject Pointer
    public partial class ProducePreparationIdolSkillSelectListItemContent : DataModel
    {
        public IdolSkillIconView?                       IdolSkillIconView                       { get; set; }
        public VoDaViMeMultiView?                       VoDaViMeMultiView                       { get; set; }
        public GameObject?                              GoVoDaViMeMultiView                     { get; set; }
        public UITextMeshProUGUI?                       IdolSkillNameText                       { get; set; }
        public GameObject?                              LockObject                              { get; set; }
        public GameObject?                              ReleaseRequirementObject                { get; set; }
        public UITextMeshProUGUI?                       ReleaseRequirementText                  { get; set; }
        public GameObject?                              ActiveObject                            { get; set; }
        public UIButton?                                SelectedButton                          { get; set; }
        public GameObject?                              BlockObject                             { get; set; }

        public static ProducePreparationIdolSkillSelectListItemContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationIdolSkillSelectListItemContent() { Pointer= p0 };

            value.IdolSkillIconView                         = GetObject<IdolSkillIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0x20 IdolSkillIconView           ( ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.VoDaViMeMultiView                         = GetObject<VoDaViMeMultiView>(new IntPtr(p + 0x028), ReversePrism.DataModels.VoDaViMeMultiView.FromPointer); // 0x28 VoDaViMeMultiView           ( ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer )
            value.GoVoDaViMeMultiView                       = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 GoVoDaViMeMultiView         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.IdolSkillNameText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 IdolSkillNameText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LockObject                                = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 LockObject                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ReleaseRequirementObject                  = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 ReleaseRequirementObject    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ReleaseRequirementText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 ReleaseRequirementText      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ActiveObject                              = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 ActiveObject                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedButton                            = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 SelectedButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BlockObject                               = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 BlockObject                 ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
