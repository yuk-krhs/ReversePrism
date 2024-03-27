using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackVitalityGauge                        0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 FrontVitalityGauge                       0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 030 FrontFlickerVitalityGauge                0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 038 VitalityFrom                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 VitalityTo                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 FromObject                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 GaugeChangeAnimator                      0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 058 ColorFadeTweener                         0001866C3DE0 ModelClassType Tweener Tweener Tweener Pointer
    // 000 SeChangeLimit                            int IL2CPP_TYPE_I4
    // 000 SeBigCrease                              string IL2CPP_TYPE_STRING
    // 000 SeLittleCrease                           string IL2CPP_TYPE_STRING
    // 000 SeBigDecrease                            string IL2CPP_TYPE_STRING
    // 000 SeLittleDecrease                         string IL2CPP_TYPE_STRING
    // 000 EmptyState                               string IL2CPP_TYPE_STRING
    // 000 IdleState                                string IL2CPP_TYPE_STRING
    // 000 Decrease1State                           string IL2CPP_TYPE_STRING
    // 000 Decrease2State                           string IL2CPP_TYPE_STRING
    // 000 Increase1State                           string IL2CPP_TYPE_STRING
    // 000 Increase2State                           string IL2CPP_TYPE_STRING
    // 060 CacheCueName                             000186671910 ModelPrimitiveType string string string String
    // 068 CacheEndAnimation                        0001866792B0 ModelClassType Action Action Action Pointer
    // 070 CacheIsCrease                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 071 IsEnd                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 074 CurrentAmount                            0001866656B0 ModelPrimitiveType float float float Single
    // 078 EstimateAmount                           0001866656B0 ModelPrimitiveType float float float Single
    public partial class ScheduleVitalityGauge
    {
        public UIImage?                                 BackVitalityGauge                       { get; set; }
        public UIImage?                                 FrontVitalityGauge                      { get; set; }
        public UIImage?                                 FrontFlickerVitalityGauge               { get; set; }
        public UITextMeshProUGUI?                       VitalityFrom                            { get; set; }
        public UITextMeshProUGUI?                       VitalityTo                              { get; set; }
        public GameObject?                              FromObject                              { get; set; }
        public Animator?                                GaugeChangeAnimator                     { get; set; }
        public Tweener?                                 ColorFadeTweener                        { get; set; }
        public string                                   CacheCueName                            { get; set; }
        public Action?                                  CacheEndAnimation                       { get; set; }
        public bool                                     CacheIsCrease                           { get; set; }
        public bool                                     IsEnd                                   { get; set; }
        public float                                    CurrentAmount                           { get; set; }
        public float                                    EstimateAmount                          { get; set; }

        public static ScheduleVitalityGauge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleVitalityGauge();

            value.BackVitalityGauge                         = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0270DA175150 0x20 BackVitalityGauge           ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.FrontVitalityGauge                        = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0270DA175170 0x28 FrontVitalityGauge          ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.FrontFlickerVitalityGauge                 = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 0270DA175190 0x30 FrontFlickerVitalityGauge   ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.VitalityFrom                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA1751B0 0x38 VitalityFrom                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VitalityTo                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA1751D0 0x40 VitalityTo                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FromObject                                = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA1751F0 0x48 FromObject                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GaugeChangeAnimator                       = GetObject<Animator>(new IntPtr(p + 0x050), ReversePrism.DataModels.Animator.FromPointer); // 0270DA175210 0x50 GaugeChangeAnimator         ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.ColorFadeTweener                          = GetObject<Tweener>(new IntPtr(p + 0x058), ReversePrism.DataModels.Tweener.FromPointer); // 0270DA175230 0x58 ColorFadeTweener            ( 0001866C3DE0 ModelClassType Tweener Tweener Tweener Pointer )
            value.CacheCueName                              = GetString(new IntPtr(p + 0x060)); // 0270DA1753B0 0x60 CacheCueName                ( 000186671910 ModelPrimitiveType string string string String )
            value.CacheEndAnimation                         = GetObject<Action>(new IntPtr(p + 0x068), ReversePrism.DataModels.Action.FromPointer); // 0270DA1753D0 0x68 CacheEndAnimation           ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.CacheIsCrease                             = GetBool(new IntPtr(p + 0x070)); // 0270DA1753F0 0x70 CacheIsCrease               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsEnd                                     = GetBool(new IntPtr(p + 0x071)); // 0270DA175410 0x71 IsEnd                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CurrentAmount                             = GetSingle(new IntPtr(p + 0x074)); // 0270DA175430 0x74 CurrentAmount               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.EstimateAmount                            = GetSingle(new IntPtr(p + 0x078)); // 0270DA175450 0x78 EstimateAmount              ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
