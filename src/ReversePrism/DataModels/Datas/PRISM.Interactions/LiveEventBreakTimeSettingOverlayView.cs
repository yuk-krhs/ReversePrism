using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 028 HowToPlayPopupOpener                     ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    // 030 BackButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 038 DescriptionText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 CellBase                                 ModelClassType LiveEventBreakTimeSettingCell LiveEventBreakTimeSettingCell LiveEventBreakTimeSettingCell Pointer
    // 048 onSelect                                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 050 CellList                                 ModelClassListType List`1<LiveEventBreakTimeSettingCell> List`1<LiveEventBreakTimeSettingCell> List<LiveEventBreakTimeSettingCell> Pointer
    // 058 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 060 EventId                                  ModelPrimitiveType int int int Int32
    public partial class LiveEventBreakTimeSettingOverlayView : DataModel
    {
        public CommonTitleView?                         TitleView                               { get; set; }
        public HowToPlayPopupOpener?                    HowToPlayPopupOpener                    { get; set; }
        public UIButton?                                BackButton                              { get; set; }
        public UITextMeshProUGUI?                       DescriptionText                         { get; set; }
        public LiveEventBreakTimeSettingCell?           CellBase                                { get; set; }
        public List<LiveEventBreakTimeSettingCell>?     CellList                                { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public int                                      EventId                                 { get; set; }

        public static LiveEventBreakTimeSettingOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventBreakTimeSettingOverlayView() { Pointer= p0 };

            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x20 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.HowToPlayPopupOpener                      = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x028), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0x28 HowToPlayPopupOpener        ( ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.BackButton                                = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 BackButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 DescriptionText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CellBase                                  = GetObject<LiveEventBreakTimeSettingCell>(new IntPtr(p + 0x040), ReversePrism.DataModels.LiveEventBreakTimeSettingCell.FromPointer); // 0x40 CellBase                    ( ModelClassType LiveEventBreakTimeSettingCell LiveEventBreakTimeSettingCell LiveEventBreakTimeSettingCell Pointer )
            value.CellList                                  = GetObjectList<LiveEventBreakTimeSettingCell>(new IntPtr(p + 0x050), ReversePrism.DataModels.LiveEventBreakTimeSettingCell.FromPointer); // 0x50 CellList                    ( ModelClassListType List`1<LiveEventBreakTimeSettingCell> List`1<LiveEventBreakTimeSettingCell> List<LiveEventBreakTimeSettingCell> Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x58 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x060)); // 0x60 EventId                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
