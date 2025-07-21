using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 028 OnClickPolicyDecideButtonList            ModelClassListType List`1<UIButton> List`1<UIButton> List<UIButton> Pointer
    // 030 ProducePolicyChoiceContentList           ModelClassListType List`1<OneSchedulePolicyContent> List`1<OneSchedulePolicyContent> List<OneSchedulePolicyContent> Pointer
    // 038 ProducePolicyListObject                  ModelClassType GameObject GameObject GameObject Pointer
    // 040 ProducePolicyDetailContentComponent      ModelClassType ProducePolicyDetailContent ProducePolicyDetailContent ProducePolicyDetailContent Pointer
    // 048 ProducePolicyDetailObject                ModelClassType GameObject GameObject GameObject Pointer
    // 050 CutinAnimator                            ModelClassType Animator Animator Animator Pointer
    // 058 SeasonNoImage                            ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 060 SafeAreaRoot                             ModelClassType RectTransform RectTransform RectTransform Pointer
    // 068 VitalityGauge                            ModelClassType ScheduleVitalityGauge ScheduleVitalityGauge ScheduleVitalityGauge Pointer
    // 070 TitleGameObject                          ModelClassType GameObject GameObject GameObject Pointer
    // 078 ProducePolicyConnector                   ModelClassType ProducePolicyConnector ProducePolicyConnector ProducePolicyConnector Pointer
    // 080 ScreenTapSkipAnimationPlayer             ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer
    // 088 BdgRecommend                             ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 090 Model3dLoader                            ModelClassType Model3dLoaderForProduceAdv Model3dLoaderForProduceAdv Model3dLoaderForProduceAdv Pointer
    // 098 Ct                                       ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 0A0 OnDecideButton                           ModelClassType Action Action Action Pointer
    // 0A8 ScenarioManager                          ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 0B0 Disposable                               ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0B8 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ProducePolicyView : DataModel
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
        public ScheduleVitalityGauge?                   VitalityGauge                           { get; set; }
        public GameObject?                              TitleGameObject                         { get; set; }
        public ProducePolicyConnector?                  ProducePolicyConnector                  { get; set; }
        public ScreenTapSkipAnimationPlayer?            ScreenTapSkipAnimationPlayer            { get; set; }
        public List<GameObject>?                        BdgRecommend                            { get; set; }
        public Model3dLoaderForProduceAdv?              Model3dLoader                           { get; set; }
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
            var value   = new ProducePolicyView() { Pointer= p0 };

            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x20 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.OnClickPolicyDecideButtonList             = GetObjectList<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 OnClickPolicyDecideButtonList ( ModelClassListType List`1<UIButton> List`1<UIButton> List<UIButton> Pointer )
            value.ProducePolicyChoiceContentList            = GetObjectList<OneSchedulePolicyContent>(new IntPtr(p + 0x030), ReversePrism.DataModels.OneSchedulePolicyContent.FromPointer); // 0x30 ProducePolicyChoiceContentList ( ModelClassListType List`1<OneSchedulePolicyContent> List`1<OneSchedulePolicyContent> List<OneSchedulePolicyContent> Pointer )
            value.ProducePolicyListObject                   = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 ProducePolicyListObject     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ProducePolicyDetailContentComponent       = GetObject<ProducePolicyDetailContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProducePolicyDetailContent.FromPointer); // 0x40 ProducePolicyDetailContentComponent ( ModelClassType ProducePolicyDetailContent ProducePolicyDetailContent ProducePolicyDetailContent Pointer )
            value.ProducePolicyDetailObject                 = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 ProducePolicyDetailObject   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CutinAnimator                             = GetObject<Animator>(new IntPtr(p + 0x050), ReversePrism.DataModels.Animator.FromPointer); // 0x50 CutinAnimator               ( ModelClassType Animator Animator Animator Pointer )
            value.SeasonNoImage                             = GetObject<UIRawImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x58 SeasonNoImage               ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.SafeAreaRoot                              = GetObject<RectTransform>(new IntPtr(p + 0x060), ReversePrism.DataModels.RectTransform.FromPointer); // 0x60 SafeAreaRoot                ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.VitalityGauge                             = GetObject<ScheduleVitalityGauge>(new IntPtr(p + 0x068), ReversePrism.DataModels.ScheduleVitalityGauge.FromPointer); // 0x68 VitalityGauge               ( ModelClassType ScheduleVitalityGauge ScheduleVitalityGauge ScheduleVitalityGauge Pointer )
            value.TitleGameObject                           = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 TitleGameObject             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ProducePolicyConnector                    = GetObject<ProducePolicyConnector>(new IntPtr(p + 0x078), ReversePrism.DataModels.ProducePolicyConnector.FromPointer); // 0x78 ProducePolicyConnector      ( ModelClassType ProducePolicyConnector ProducePolicyConnector ProducePolicyConnector Pointer )
            value.ScreenTapSkipAnimationPlayer              = GetObject<ScreenTapSkipAnimationPlayer>(new IntPtr(p + 0x080), ReversePrism.DataModels.ScreenTapSkipAnimationPlayer.FromPointer); // 0x80 ScreenTapSkipAnimationPlayer ( ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer )
            value.BdgRecommend                              = GetObjectList<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 BdgRecommend                ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Model3dLoader                             = GetObject<Model3dLoaderForProduceAdv>(new IntPtr(p + 0x090), ReversePrism.DataModels.Model3dLoaderForProduceAdv.FromPointer); // 0x90 Model3dLoader               ( ModelClassType Model3dLoaderForProduceAdv Model3dLoaderForProduceAdv Model3dLoaderForProduceAdv Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x098)); // 0x98 Ct                          ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.OnDecideButton                            = GetObject<Action>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Action.FromPointer); // 0xA0 OnDecideButton              ( ModelClassType Action Action Action Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0xA8 ScenarioManager             ( ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IDisposable.FromPointer); // 0xB0 Disposable                  ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.IDisposable.FromPointer); // 0xB8 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
