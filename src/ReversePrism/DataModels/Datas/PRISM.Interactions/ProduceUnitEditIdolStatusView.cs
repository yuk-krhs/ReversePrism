using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IdolTapAreaViews                         000185B8AFA0 ModelClassListType IdolTapAreaView[] IdolTapAreaView[] List<IdolTapAreaView> Pointer
    // 028 BtnRightArrow                            0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 BtnLeftArrow                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 IdolStatusSkillViews                     000185B8AEC0 ModelClassListType IdolStatusSkillView[] IdolStatusSkillView[] List<IdolStatusSkillView> Pointer
    // 040 StatusOpenTarget                         000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 StatusToggle                             000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 050 StatusOpenIcon                           0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 058 StatusCloseIcon                          0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 060 SwipeToggle                              0001865FCA50 ModelClassType SwipeToggle SwipeToggle SwipeToggle Pointer
    // 068 pageMove                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 070 onSwipe                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 078 IsStatusOpen                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 080 <OnIdolTap>k__BackingField               IObservable`1<int> IL2CPP_TYPE_GENERICINST
    // 088 <OnIdolLongTap>k__BackingField           IObservable`1<int> IL2CPP_TYPE_GENERICINST
    // 090 <OnSkillIconOrder>k__BackingField        IObservable`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ProduceUnitEditIdolStatusView
    {
        public List<IdolTapAreaView>?                   IdolTapAreaViews                        { get; set; }
        public UIButton?                                BtnRightArrow                           { get; set; }
        public UIButton?                                BtnLeftArrow                            { get; set; }
        public List<IdolStatusSkillView>?               IdolStatusSkillViews                    { get; set; }
        public RectTransform?                           StatusOpenTarget                        { get; set; }
        public ToggleButton?                            StatusToggle                            { get; set; }
        public UIImage?                                 StatusOpenIcon                          { get; set; }
        public UIImage?                                 StatusCloseIcon                         { get; set; }
        public SwipeToggle?                             SwipeToggle                             { get; set; }
        public bool                                     IsStatusOpen                            { get; set; }

        public static ProduceUnitEditIdolStatusView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceUnitEditIdolStatusView();

            value.IdolTapAreaViews                          = GetObjectList<IdolTapAreaView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolTapAreaView.FromPointer); // 0270DA378210 0x20 IdolTapAreaViews            ( 000185B8AFA0 ModelClassListType IdolTapAreaView[] IdolTapAreaView[] List<IdolTapAreaView> Pointer )
            value.BtnRightArrow                             = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA378230 0x28 BtnRightArrow               ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnLeftArrow                              = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA378250 0x30 BtnLeftArrow                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.IdolStatusSkillViews                      = GetObjectList<IdolStatusSkillView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IdolStatusSkillView.FromPointer); // 0270DA378270 0x38 IdolStatusSkillViews        ( 000185B8AEC0 ModelClassListType IdolStatusSkillView[] IdolStatusSkillView[] List<IdolStatusSkillView> Pointer )
            value.StatusOpenTarget                          = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DA378290 0x40 StatusOpenTarget            ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.StatusToggle                              = GetObject<ToggleButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270DA3782B0 0x48 StatusToggle                ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.StatusOpenIcon                            = GetObject<UIImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIImage.FromPointer); // 0270DA3782D0 0x50 StatusOpenIcon              ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.StatusCloseIcon                           = GetObject<UIImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIImage.FromPointer); // 0270DA3782F0 0x58 StatusCloseIcon             ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.SwipeToggle                               = GetObject<SwipeToggle>(new IntPtr(p + 0x060), ReversePrism.DataModels.SwipeToggle.FromPointer); // 0270DA378310 0x60 SwipeToggle                 ( 0001865FCA50 ModelClassType SwipeToggle SwipeToggle SwipeToggle Pointer )
            value.IsStatusOpen                              = GetBool(new IntPtr(p + 0x078)); // 0270DA378370 0x78 IsStatusOpen                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
