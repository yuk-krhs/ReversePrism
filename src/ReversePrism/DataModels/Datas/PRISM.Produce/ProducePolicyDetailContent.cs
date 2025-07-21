using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 OneSchedulePolicyContent                 ModelClassType OneSchedulePolicyContent OneSchedulePolicyContent OneSchedulePolicyContent Pointer
    // 028 PolicyDescriptionText                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 PolicyDescriptionContent                 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 AgreeButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 040 CancelButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 048 AgreeButtonBackImageObjectList           ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 050 BdgRecommend                             ModelClassType GameObject GameObject GameObject Pointer
    // 058 CallBackDecideScenario                   ModelClassType Action Action Action Pointer
    // 060 CallBackCancelScenario                   ModelClassType Action Action Action Pointer
    public partial class ProducePolicyDetailContent : DataModel
    {
        public OneSchedulePolicyContent?                OneSchedulePolicyContent                { get; set; }
        public UITextMeshProUGUI?                       PolicyDescriptionText                   { get; set; }
        public RectTransform?                           PolicyDescriptionContent                { get; set; }
        public UIButton?                                AgreeButton                             { get; set; }
        public UIButton?                                CancelButton                            { get; set; }
        public List<GameObject>?                        AgreeButtonBackImageObjectList          { get; set; }
        public GameObject?                              BdgRecommend                            { get; set; }
        public Action?                                  CallBackDecideScenario                  { get; set; }
        public Action?                                  CallBackCancelScenario                  { get; set; }

        public static ProducePolicyDetailContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePolicyDetailContent() { Pointer= p0 };

            value.OneSchedulePolicyContent                  = GetObject<OneSchedulePolicyContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.OneSchedulePolicyContent.FromPointer); // 0x20 OneSchedulePolicyContent    ( ModelClassType OneSchedulePolicyContent OneSchedulePolicyContent OneSchedulePolicyContent Pointer )
            value.PolicyDescriptionText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 PolicyDescriptionText       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PolicyDescriptionContent                  = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0x30 PolicyDescriptionContent    ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.AgreeButton                               = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 AgreeButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CancelButton                              = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 CancelButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.AgreeButtonBackImageObjectList            = GetObjectList<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 AgreeButtonBackImageObjectList ( ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.BdgRecommend                              = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 BdgRecommend                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CallBackDecideScenario                    = GetObject<Action>(new IntPtr(p + 0x058), ReversePrism.DataModels.Action.FromPointer); // 0x58 CallBackDecideScenario      ( ModelClassType Action Action Action Pointer )
            value.CallBackCancelScenario                    = GetObject<Action>(new IntPtr(p + 0x060), ReversePrism.DataModels.Action.FromPointer); // 0x60 CallBackCancelScenario      ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
