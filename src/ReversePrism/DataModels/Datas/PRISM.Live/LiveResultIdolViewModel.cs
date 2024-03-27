using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Level                                    00018656FB80 ModelClassType LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel Pointer
    // 018 Dearness                                 00018656FB80 ModelClassType LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel Pointer
    // 020 Fan                                      ValueTuple`2<long, long> IL2CPP_TYPE_GENERICINST
    public partial class LiveResultIdolViewModel
    {
        public LiveResultIdolGaugeViewModel?            Level                                   { get; set; }
        public LiveResultIdolGaugeViewModel?            Dearness                                { get; set; }

        public static LiveResultIdolViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultIdolViewModel();

            value.Level                                     = GetObject<LiveResultIdolGaugeViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.LiveResultIdolGaugeViewModel.FromPointer); // 0270D5239618 0x10 Level                       ( 00018656FB80 ModelClassType LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel Pointer )
            value.Dearness                                  = GetObject<LiveResultIdolGaugeViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.LiveResultIdolGaugeViewModel.FromPointer); // 0270D5239638 0x18 Dearness                    ( 00018656FB80 ModelClassType LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel LiveResultIdolGaugeViewModel Pointer )

            return value;
        }
    }
}
