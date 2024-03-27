using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Buttons                                  000185CADC58 ModelClassListType UIButton[] UIButton[] List<UIButton> Pointer
    // 028 DisplayUIInfos                           000185CBC368 ModelClassListType DisplayUIInfo[] DisplayUIInfo[] List<DisplayUIInfo> Pointer
    // 030 SuccessPanelType                         000186606230 ModelEnumType PanelType PanelType PanelType Int32
    // 034 FailurePanelType                         000186606230 ModelEnumType PanelType PanelType PanelType Int32
    // 038 onClickButton                            Subject`1<ButtonType> IL2CPP_TYPE_GENERICINST
    public partial class InGameFinishPanel
    {
        public List<UIButton>?                          Buttons                                 { get; set; }
        public List<DisplayUIInfo>?                     DisplayUIInfos                          { get; set; }
        public PanelType                                SuccessPanelType                        { get; set; }
        public PanelType                                FailurePanelType                        { get; set; }

        public static InGameFinishPanel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameFinishPanel();

            value.Buttons                                   = GetObjectList<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5C4EB98 0x20 Buttons                     ( 000185CADC58 ModelClassListType UIButton[] UIButton[] List<UIButton> Pointer )
            value.DisplayUIInfos                            = GetObjectList<DisplayUIInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.DisplayUIInfo.FromPointer); // 0270D5C4EBB8 0x28 DisplayUIInfos              ( 000185CBC368 ModelClassListType DisplayUIInfo[] DisplayUIInfo[] List<DisplayUIInfo> Pointer )
            value.SuccessPanelType                          = (PanelType)GetInt32(new IntPtr(p + 0x030)); // 0270D5C4EBD8 0x30 SuccessPanelType            ( 000186606230 ModelEnumType PanelType PanelType PanelType Int32 )
            value.FailurePanelType                          = (PanelType)GetInt32(new IntPtr(p + 0x034)); // 0270D5C4EBF8 0x34 FailurePanelType            ( 000186606230 ModelEnumType PanelType PanelType PanelType Int32 )

            return value;
        }
    }
}
