using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 ViewModel                                0001865D4E50 ModelClassType SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel Pointer
    // 098 UnitParam                                0001865EF350 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    public partial class SubSeasonDetailPopupParam
    {
        public SubSeasonDetailContentViewModel?         ViewModel                               { get; set; }
        public IProduceParameterStatus?                 UnitParam                               { get; set; }

        public static SubSeasonDetailPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubSeasonDetailPopupParam();

            value.ViewModel                                 = GetObject<SubSeasonDetailContentViewModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.SubSeasonDetailContentViewModel.FromPointer); // 0270D4D2B840 0x90 ViewModel                   ( 0001865D4E50 ModelClassType SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel Pointer )
            value.UnitParam                                 = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x098), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0270D4D2B860 0x98 UnitParam                   ( 0001865EF350 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )

            return value;
        }
    }
}
