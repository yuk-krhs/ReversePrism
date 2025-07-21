using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Level                                    ModelClassType LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel Pointer
    // 018 Dearness                                 ModelClassType LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel Pointer
    // 020 Fan                                      ValueTuple`2<long, long> IL2CPP_TYPE_GENERICINST
    public partial class LiveResultIdolViewModel : DataModel
    {
        public LiveResultIdolGaugeViewModel?            Level                                   { get; set; }
        public LiveResultIdolGaugeViewModel?            Dearness                                { get; set; }

        public static LiveResultIdolViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultIdolViewModel() { Pointer= p0 };

            value.Level                                     = GetObject<LiveResultIdolGaugeViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.LiveResultIdolGaugeViewModel.FromPointer); // 0x10 Level                       ( ModelClassType LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel Pointer )
            value.Dearness                                  = GetObject<LiveResultIdolGaugeViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.LiveResultIdolGaugeViewModel.FromPointer); // 0x18 Dearness                    ( ModelClassType LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel Pointer )

            return value;
        }
    }
}
