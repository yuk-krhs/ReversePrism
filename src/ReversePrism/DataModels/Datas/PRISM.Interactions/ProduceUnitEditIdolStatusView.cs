using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IdolTapAreaViews                         ModelClassListType IdolTapAreaView[] IdolTapAreaView[] List<IdolTapAreaView> Pointer
    // 028 BtnRightArrow                            ModelClassType UIButton UIButton UIButton Pointer
    // 030 BtnLeftArrow                             ModelClassType UIButton UIButton UIButton Pointer
    // 038 IdolStatusSkillViews                     ModelClassListType IdolStatusSkillView[] IdolStatusSkillView[] List<IdolStatusSkillView> Pointer
    // 040 StatusOpenTarget                         ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 StatusToggle                             ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 050 StatusOpenIcon                           ModelClassType UIImage UIImage UIImage Pointer
    // 058 StatusCloseIcon                          ModelClassType UIImage UIImage UIImage Pointer
    // 060 SwipeToggle                              ModelClassType SwipeToggle SwipeToggle SwipeToggle Pointer
    // 068 pageMove                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 070 onSwipe                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 078 IsStatusOpen                             ModelPrimitiveType bool bool bool Bool
    // 080 <OnIdolTap>k__BackingField               IObservable`1<int> IL2CPP_TYPE_GENERICINST
    // 088 <OnIdolLongTap>k__BackingField           IObservable`1<int> IL2CPP_TYPE_GENERICINST
    // 090 <OnSkillIconOrder>k__BackingField        IObservable`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ProduceUnitEditIdolStatusView : DataModel
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
            var value   = new ProduceUnitEditIdolStatusView() { Pointer= p0 };

            value.IdolTapAreaViews                          = GetObjectList<IdolTapAreaView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolTapAreaView.FromPointer); // 0x20 IdolTapAreaViews            ( ModelClassListType IdolTapAreaView[] IdolTapAreaView[] List<IdolTapAreaView> Pointer )
            value.BtnRightArrow                             = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 BtnRightArrow               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnLeftArrow                              = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 BtnLeftArrow                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.IdolStatusSkillViews                      = GetObjectList<IdolStatusSkillView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IdolStatusSkillView.FromPointer); // 0x38 IdolStatusSkillViews        ( ModelClassListType IdolStatusSkillView[] IdolStatusSkillView[] List<IdolStatusSkillView> Pointer )
            value.StatusOpenTarget                          = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0x40 StatusOpenTarget            ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.StatusToggle                              = GetObject<ToggleButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x48 StatusToggle                ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.StatusOpenIcon                            = GetObject<UIImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIImage.FromPointer); // 0x50 StatusOpenIcon              ( ModelClassType UIImage UIImage UIImage Pointer )
            value.StatusCloseIcon                           = GetObject<UIImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIImage.FromPointer); // 0x58 StatusCloseIcon             ( ModelClassType UIImage UIImage UIImage Pointer )
            value.SwipeToggle                               = GetObject<SwipeToggle>(new IntPtr(p + 0x060), ReversePrism.DataModels.SwipeToggle.FromPointer); // 0x60 SwipeToggle                 ( ModelClassType SwipeToggle SwipeToggle SwipeToggle Pointer )
            value.IsStatusOpen                              = GetBool(new IntPtr(p + 0x078)); // 0x78 IsStatusOpen                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
