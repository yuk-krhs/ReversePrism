using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PIdolIcon                                ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer
    // 018 FIdolIcon                                ModelClassType FIdolIcon FIdolIcon FIdolIcon Pointer
    // 020 IdolParameter                            ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    // 028 BaseBonusParameter                       ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer
    public partial class PFIdolParameterDetailPopupViewModel : DataModel
    {
        public PIdolIcon?                               PIdolIcon                               { get; set; }
        public FIdolIcon?                               FIdolIcon                               { get; set; }
        public IProduceParameterStatus?                 IdolParameter                           { get; set; }
        public IIdolParameterStatus?                    BaseBonusParameter                      { get; set; }

        public static PFIdolParameterDetailPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PFIdolParameterDetailPopupViewModel() { Pointer= p0 };

            value.PIdolIcon                                 = GetObject<PIdolIcon>(new IntPtr(p + 0x010), ReversePrism.DataModels.PIdolIcon.FromPointer); // 0x10 PIdolIcon                   ( ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer )
            value.FIdolIcon                                 = GetObject<FIdolIcon>(new IntPtr(p + 0x018), ReversePrism.DataModels.FIdolIcon.FromPointer); // 0x18 FIdolIcon                   ( ModelClassType FIdolIcon FIdolIcon FIdolIcon Pointer )
            value.IdolParameter                             = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0x20 IdolParameter               ( ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )
            value.BaseBonusParameter                        = GetObject<IIdolParameterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IIdolParameterStatus.FromPointer); // 0x28 BaseBonusParameter          ( ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer )

            return value;
        }
    }
}
