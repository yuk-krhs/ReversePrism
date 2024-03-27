using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroup                                 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 FIdolInfoView                            000186541950 ModelClassType FIdolDetailFIdolInfoView FIdolDetailFIdolInfoView FIdolDetailFIdolInfoView Pointer
    // 030 SkillView                                000186544290 ModelClassType FIdolDetailSkillView FIdolDetailSkillView FIdolDetailSkillView Pointer
    // 038 UnitInfoView                             000186544780 ModelClassType FIdolDetailUnitInfoView FIdolDetailUnitInfoView FIdolDetailUnitInfoView Pointer
    // 040 ProduceInfoView                          000186543D50 ModelClassType FIdolDetailProduceInfoView FIdolDetailProduceInfoView FIdolDetailProduceInfoView Pointer
    // 048 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class FIdolDetailPopupView
    {
        public UITabGroup?                              TabGroup                                { get; set; }
        public FIdolDetailFIdolInfoView?                FIdolInfoView                           { get; set; }
        public FIdolDetailSkillView?                    SkillView                               { get; set; }
        public FIdolDetailUnitInfoView?                 UnitInfoView                            { get; set; }
        public FIdolDetailProduceInfoView?              ProduceInfoView                         { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static FIdolDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FIdolDetailPopupView();

            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0270DA2ADD20 0x20 TabGroup                    ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.FIdolInfoView                             = GetObject<FIdolDetailFIdolInfoView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FIdolDetailFIdolInfoView.FromPointer); // 0270DA2ADD40 0x28 FIdolInfoView               ( 000186541950 ModelClassType FIdolDetailFIdolInfoView FIdolDetailFIdolInfoView FIdolDetailFIdolInfoView Pointer )
            value.SkillView                                 = GetObject<FIdolDetailSkillView>(new IntPtr(p + 0x030), ReversePrism.DataModels.FIdolDetailSkillView.FromPointer); // 0270DA2ADD60 0x30 SkillView                   ( 000186544290 ModelClassType FIdolDetailSkillView FIdolDetailSkillView FIdolDetailSkillView Pointer )
            value.UnitInfoView                              = GetObject<FIdolDetailUnitInfoView>(new IntPtr(p + 0x038), ReversePrism.DataModels.FIdolDetailUnitInfoView.FromPointer); // 0270DA2ADD80 0x38 UnitInfoView                ( 000186544780 ModelClassType FIdolDetailUnitInfoView FIdolDetailUnitInfoView FIdolDetailUnitInfoView Pointer )
            value.ProduceInfoView                           = GetObject<FIdolDetailProduceInfoView>(new IntPtr(p + 0x040), ReversePrism.DataModels.FIdolDetailProduceInfoView.FromPointer); // 0270DA2ADDA0 0x40 ProduceInfoView             ( 000186543D50 ModelClassType FIdolDetailProduceInfoView FIdolDetailProduceInfoView FIdolDetailProduceInfoView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA2ADDE0 0x50 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
