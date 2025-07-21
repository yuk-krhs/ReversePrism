using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackVitalityGauge                        ModelClassType UIImage UIImage UIImage Pointer
    // 028 FrontVitalityGauge                       ModelClassType UIImage UIImage UIImage Pointer
    // 030 FrontFlickerVitalityGauge                ModelClassType UIImage UIImage UIImage Pointer
    // 038 VitalityFrom                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 VitalityTo                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 FromObject                               ModelClassType GameObject GameObject GameObject Pointer
    // 050 GaugeChangeAnimator                      ModelClassType Animator Animator Animator Pointer
    // 058 AnimatorEvent                            ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 060 ColorFadeTweener                         ModelClassType Tweener Tweener Tweener Pointer
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
    // 000 StartState                               string IL2CPP_TYPE_STRING
    // 000 EndState                                 string IL2CPP_TYPE_STRING
    // 068 CacheCueName                             ModelPrimitiveType string string string String
    // 070 CacheEndAnimation                        ModelClassType Action Action Action Pointer
    // 078 CacheIsCrease                            ModelPrimitiveType bool bool bool Bool
    // 079 IsEnd                                    ModelPrimitiveType bool bool bool Bool
    // 07C CurrentAmount                            ModelPrimitiveType float float float Single
    // 080 EstimateAmount                           ModelPrimitiveType float float float Single
    // 084 SePlayback                               ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    public partial class ScheduleVitalityGauge : DataModel
    {
        public UIImage?                                 BackVitalityGauge                       { get; set; }
        public UIImage?                                 FrontVitalityGauge                      { get; set; }
        public UIImage?                                 FrontFlickerVitalityGauge               { get; set; }
        public UITextMeshProUGUI?                       VitalityFrom                            { get; set; }
        public UITextMeshProUGUI?                       VitalityTo                              { get; set; }
        public GameObject?                              FromObject                              { get; set; }
        public Animator?                                GaugeChangeAnimator                     { get; set; }
        public AnimatorWithEvent?                       AnimatorEvent                           { get; set; }
        public Tweener?                                 ColorFadeTweener                        { get; set; }
        public string                                   CacheCueName                            { get; set; }
        public Action?                                  CacheEndAnimation                       { get; set; }
        public bool                                     CacheIsCrease                           { get; set; }
        public bool                                     IsEnd                                   { get; set; }
        public float                                    CurrentAmount                           { get; set; }
        public float                                    EstimateAmount                          { get; set; }
        public CriAtomExPlayback                        SePlayback                              { get; set; }

        public static ScheduleVitalityGauge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleVitalityGauge() { Pointer= p0 };

            value.BackVitalityGauge                         = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 BackVitalityGauge           ( ModelClassType UIImage UIImage UIImage Pointer )
            value.FrontVitalityGauge                        = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0x28 FrontVitalityGauge          ( ModelClassType UIImage UIImage UIImage Pointer )
            value.FrontFlickerVitalityGauge                 = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 0x30 FrontFlickerVitalityGauge   ( ModelClassType UIImage UIImage UIImage Pointer )
            value.VitalityFrom                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 VitalityFrom                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VitalityTo                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 VitalityTo                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FromObject                                = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 FromObject                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GaugeChangeAnimator                       = GetObject<Animator>(new IntPtr(p + 0x050), ReversePrism.DataModels.Animator.FromPointer); // 0x50 GaugeChangeAnimator         ( ModelClassType Animator Animator Animator Pointer )
            value.AnimatorEvent                             = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x058), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0x58 AnimatorEvent               ( ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.ColorFadeTweener                          = GetObject<Tweener>(new IntPtr(p + 0x060), ReversePrism.DataModels.Tweener.FromPointer); // 0x60 ColorFadeTweener            ( ModelClassType Tweener Tweener Tweener Pointer )
            value.CacheCueName                              = GetString(new IntPtr(p + 0x068)); // 0x68 CacheCueName                ( ModelPrimitiveType string string string String )
            value.CacheEndAnimation                         = GetObject<Action>(new IntPtr(p + 0x070), ReversePrism.DataModels.Action.FromPointer); // 0x70 CacheEndAnimation           ( ModelClassType Action Action Action Pointer )
            value.CacheIsCrease                             = GetBool(new IntPtr(p + 0x078)); // 0x78 CacheIsCrease               ( ModelPrimitiveType bool bool bool Bool )
            value.IsEnd                                     = GetBool(new IntPtr(p + 0x079)); // 0x79 IsEnd                       ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentAmount                             = GetSingle(new IntPtr(p + 0x07C)); // 0x7C CurrentAmount               ( ModelPrimitiveType float float float Single )
            value.EstimateAmount                            = GetSingle(new IntPtr(p + 0x080)); // 0x80 EstimateAmount              ( ModelPrimitiveType float float float Single )
            value.SePlayback                                = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x084)); // 0x84 SePlayback                  ( ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )

            return value;
        }
    }
}
