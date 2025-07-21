using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Icon                                     ModelClassType PFIdolIconViewBase PFIdolIconViewBase PFIdolIconViewBase Pointer
    // 028 LevelGauge                               ModelClassType LiveResultIdolGaugeView LiveResultIdolGaugeView LiveResultIdolGaugeView Pointer
    // 030 DearnessGauge                            ModelClassType LiveResultIdolGaugeView LiveResultIdolGaugeView LiveResultIdolGaugeView Pointer
    // 038 FanText                                  ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 040 DiffFanText                              ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 048 CharacterId                              ModelPrimitiveType int int int Int32
    public partial class LiveResultIdolView : DataModel
    {
        public PFIdolIconViewBase?                      Icon                                    { get; set; }
        public LiveResultIdolGaugeView?                 LevelGauge                              { get; set; }
        public LiveResultIdolGaugeView?                 DearnessGauge                           { get; set; }
        public TextMeshProUGUI?                         FanText                                 { get; set; }
        public TextMeshProUGUI?                         DiffFanText                             { get; set; }
        public int                                      CharacterId                             { get; set; }

        public static LiveResultIdolView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultIdolView() { Pointer= p0 };

            value.Icon                                      = GetObject<PFIdolIconViewBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconViewBase.FromPointer); // 0x20 Icon                        ( ModelClassType PFIdolIconViewBase PFIdolIconViewBase PFIdolIconViewBase Pointer )
            value.LevelGauge                                = GetObject<LiveResultIdolGaugeView>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveResultIdolGaugeView.FromPointer); // 0x28 LevelGauge                  ( ModelClassType LiveResultIdolGaugeView LiveResultIdolGaugeView LiveResultIdolGaugeView Pointer )
            value.DearnessGauge                             = GetObject<LiveResultIdolGaugeView>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveResultIdolGaugeView.FromPointer); // 0x30 DearnessGauge               ( ModelClassType LiveResultIdolGaugeView LiveResultIdolGaugeView LiveResultIdolGaugeView Pointer )
            value.FanText                                   = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x38 FanText                     ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.DiffFanText                               = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x40 DiffFanText                 ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.CharacterId                               = GetInt32(new IntPtr(p + 0x048)); // 0x48 CharacterId                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
