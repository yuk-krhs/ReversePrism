using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleView                                0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 028 OnClickPolicyDecideButtonList            000185D17588 ModelClassListType List`1<UIButton> List`1<UIButton> List<UIButton> Pointer
    // 030 ProducePolicyChoiceContentList           000185CF6D28 ModelClassListType List`1<OneSchedulePolicyContent> List`1<OneSchedulePolicyContent> List<OneSchedulePolicyContent> Pointer
    // 038 ProducePolicyListObject                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 ProducePolicyDetailContentComponent      000186564900 ModelClassType ProducePolicyDetailContent ProducePolicyDetailContent ProducePolicyDetailContent Pointer
    // 048 ProducePolicyDetailObject                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 CutinAnimator                            0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 058 SeasonNoImage                            0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 060 SafeAreaRoot                             000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 068 VitalityGauge                            00018652E260 ModelClassType VitalityGauge VitalityGauge VitalityGauge Pointer
    // 070 TitleGameObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 ProducePolicyConnector                   000186564100 ModelClassType ProducePolicyConnector ProducePolicyConnector ProducePolicyConnector Pointer
    // 080 BdgRecommend                             000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 088 Ct                                       00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 090 OnDecideButton                           0001866792B0 ModelClassType Action Action Action Pointer
    // 098 ScenarioManager                          0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 0A0 Disposable                               0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0A8 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ProducePolicyView
    {
        public CommonTitleView?                         TitleView                               { get; set; }
        public List<UIButton>?                          OnClickPolicyDecideButtonList           { get; set; }
        public List<OneSchedulePolicyContent>?          ProducePolicyChoiceContentList          { get; set; }
        public GameObject?                              ProducePolicyListObject                 { get; set; }
        public ProducePolicyDetailContent?              ProducePolicyDetailContentComponent     { get; set; }
        public GameObject?                              ProducePolicyDetailObject               { get; set; }
        public Animator?                                CutinAnimator                           { get; set; }
        public UIRawImage?                              SeasonNoImage                           { get; set; }
        public RectTransform?                           SafeAreaRoot                            { get; set; }
        public VitalityGauge?                           VitalityGauge                           { get; set; }
        public GameObject?                              TitleGameObject                         { get; set; }
        public ProducePolicyConnector?                  ProducePolicyConnector                  { get; set; }
        public List<GameObject>?                        BdgRecommend                            { get; set; }
        public CancellationToken                        Ct                                      { get; set; }
        public Action?                                  OnDecideButton                          { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }
        public IDisposable?                             Disposable                              { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }

        public static ProducePolicyView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePolicyView();

            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270DA171E60 0x20 TitleView                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.OnClickPolicyDecideButtonList             = GetObjectList<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA171E80 0x28 OnClickPolicyDecideButtonList ( 000185D17588 ModelClassListType List`1<UIButton> List`1<UIButton> List<UIButton> Pointer )
            value.ProducePolicyChoiceContentList            = GetObjectList<OneSchedulePolicyContent>(new IntPtr(p + 0x030), ReversePrism.DataModels.OneSchedulePolicyContent.FromPointer); // 0270DA171EA0 0x30 ProducePolicyChoiceContentList ( 000185CF6D28 ModelClassListType List`1<OneSchedulePolicyContent> List`1<OneSchedulePolicyContent> List<OneSchedulePolicyContent> Pointer )
            value.ProducePolicyListObject                   = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA171EC0 0x38 ProducePolicyListObject     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ProducePolicyDetailContentComponent       = GetObject<ProducePolicyDetailContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProducePolicyDetailContent.FromPointer); // 0270DA171EE0 0x40 ProducePolicyDetailContentComponent ( 000186564900 ModelClassType ProducePolicyDetailContent ProducePolicyDetailContent ProducePolicyDetailContent Pointer )
            value.ProducePolicyDetailObject                 = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA171F00 0x48 ProducePolicyDetailObject   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CutinAnimator                             = GetObject<Animator>(new IntPtr(p + 0x050), ReversePrism.DataModels.Animator.FromPointer); // 0270DA171F20 0x50 CutinAnimator               ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.SeasonNoImage                             = GetObject<UIRawImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270DA171F40 0x58 SeasonNoImage               ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.SafeAreaRoot                              = GetObject<RectTransform>(new IntPtr(p + 0x060), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DA171F60 0x60 SafeAreaRoot                ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.VitalityGauge                             = GetObject<VitalityGauge>(new IntPtr(p + 0x068), ReversePrism.DataModels.VitalityGauge.FromPointer); // 0270DA171F80 0x68 VitalityGauge               ( 00018652E260 ModelClassType VitalityGauge VitalityGauge VitalityGauge Pointer )
            value.TitleGameObject                           = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA171FA0 0x70 TitleGameObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ProducePolicyConnector                    = GetObject<ProducePolicyConnector>(new IntPtr(p + 0x078), ReversePrism.DataModels.ProducePolicyConnector.FromPointer); // 0270DA171FC0 0x78 ProducePolicyConnector      ( 000186564100 ModelClassType ProducePolicyConnector ProducePolicyConnector ProducePolicyConnector Pointer )
            value.BdgRecommend                              = GetObjectList<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA171FE0 0x80 BdgRecommend                ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x088)); // 0270DA172000 0x88 Ct                          ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.OnDecideButton                            = GetObject<Action>(new IntPtr(p + 0x090), ReversePrism.DataModels.Action.FromPointer); // 0270DA172020 0x90 OnDecideButton              ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x098), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0270DA172040 0x98 ScenarioManager             ( 0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DA172060 0xA0 Disposable                  ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DA172080 0xA8 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
