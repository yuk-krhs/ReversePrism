using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 ViewModel                                ModelClassType SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel Pointer
    // 098 UnitParam                                ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    public partial class SubSeasonDetailPopupParam : DataModel
    {
        public SubSeasonDetailContentViewModel?         ViewModel                               { get; set; }
        public IProduceParameterStatus?                 UnitParam                               { get; set; }

        public static SubSeasonDetailPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubSeasonDetailPopupParam() { Pointer= p0 };

            value.ViewModel                                 = GetObject<SubSeasonDetailContentViewModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.SubSeasonDetailContentViewModel.FromPointer); // 0x90 ViewModel                   ( ModelClassType SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel Pointer )
            value.UnitParam                                 = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x098), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0x98 UnitParam                   ( ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )

            return value;
        }
    }
}
