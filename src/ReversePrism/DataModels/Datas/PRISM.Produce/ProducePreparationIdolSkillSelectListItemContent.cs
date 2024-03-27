using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IdolSkillIconView                        0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 028 VoDaViMeMultiView                        000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer
    // 030 GoVoDaViMeMultiView                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 IdolSkillNameText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 LockObject                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 ReleaseRequirementObject                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 ReleaseRequirementText                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ActiveObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 SelectedButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 BlockObject                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class ProducePreparationIdolSkillSelectListItemContent
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
            var value   = new ProducePreparationIdolSkillSelectListItemContent();

            value.IdolSkillIconView                         = GetObject<IdolSkillIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0270D5A388A8 0x20 IdolSkillIconView           ( 0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.VoDaViMeMultiView                         = GetObject<VoDaViMeMultiView>(new IntPtr(p + 0x028), ReversePrism.DataModels.VoDaViMeMultiView.FromPointer); // 0270D5A388C8 0x28 VoDaViMeMultiView           ( 000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer )
            value.GoVoDaViMeMultiView                       = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5A388E8 0x30 GoVoDaViMeMultiView         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.IdolSkillNameText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A38908 0x38 IdolSkillNameText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LockObject                                = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5A38928 0x40 LockObject                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ReleaseRequirementObject                  = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5A38948 0x48 ReleaseRequirementObject    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ReleaseRequirementText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A38968 0x50 ReleaseRequirementText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ActiveObject                              = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5A38988 0x58 ActiveObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedButton                            = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5A389A8 0x60 SelectedButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BlockObject                               = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5A389C8 0x68 BlockObject                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
