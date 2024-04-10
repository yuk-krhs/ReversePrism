using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 OneSchedulePolicyContent                 0001866DDA60 ModelClassType OneSchedulePolicyContent OneSchedulePolicyContent OneSchedulePolicyContent Pointer
    // 028 PolicyDescriptionText                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 PolicyDescriptionContent                 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 AgreeButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 CancelButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 AgreeButtonBackImageObjectList           000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 050 BdgRecommend                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 CallBackDecideScenario                   000186679A00 ModelClassType Action Action Action Pointer
    // 060 CallBackCancelScenario                   000186679A00 ModelClassType Action Action Action Pointer
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

            value.OneSchedulePolicyContent                  = GetObject<OneSchedulePolicyContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.OneSchedulePolicyContent.FromPointer); // 024665D90978 0x20 OneSchedulePolicyContent    ( 0001866DDA60 ModelClassType OneSchedulePolicyContent OneSchedulePolicyContent OneSchedulePolicyContent Pointer )
            value.PolicyDescriptionText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665D90998 0x28 PolicyDescriptionText       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PolicyDescriptionContent                  = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 024665D909B8 0x30 PolicyDescriptionContent    ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.AgreeButton                               = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 024665D909D8 0x38 AgreeButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CancelButton                              = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 024665D909F8 0x40 CancelButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.AgreeButtonBackImageObjectList            = GetObjectList<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 024665D90A18 0x48 AgreeButtonBackImageObjectList ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.BdgRecommend                              = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 024665D90A38 0x50 BdgRecommend                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CallBackDecideScenario                    = GetObject<Action>(new IntPtr(p + 0x058), ReversePrism.DataModels.Action.FromPointer); // 024665D90A58 0x58 CallBackDecideScenario      ( 000186679A00 ModelClassType Action Action Action Pointer )
            value.CallBackCancelScenario                    = GetObject<Action>(new IntPtr(p + 0x060), ReversePrism.DataModels.Action.FromPointer); // 024665D90A78 0x60 CallBackCancelScenario      ( 000186679A00 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
