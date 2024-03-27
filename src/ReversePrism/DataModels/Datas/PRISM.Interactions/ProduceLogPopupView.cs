using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ProduceLogCellListView                   00018655CDA0 ModelClassType ProduceLogCellListView ProduceLogCellListView ProduceLogCellListView Pointer
    // 028 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 FrameParam                               000186762FA0 ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer
    // 038 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceLogPopupView
    {
        public ProduceLogCellListView?                  ProduceLogCellListView                  { get; set; }
        public PopupFrameParameter?                     FrameParam                              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceLogPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceLogPopupView();

            value.ProduceLogCellListView                    = GetObject<ProduceLogCellListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceLogCellListView.FromPointer); // 0270DA115040 0x20 ProduceLogCellListView      ( 00018655CDA0 ModelClassType ProduceLogCellListView ProduceLogCellListView ProduceLogCellListView Pointer )
            value.FrameParam                                = GetObject<PopupFrameParameter>(new IntPtr(p + 0x030), ReversePrism.DataModels.PopupFrameParameter.FromPointer); // 0270DA115080 0x30 FrameParam                  ( 000186762FA0 ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA1150A0 0x38 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
