using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GashaRateStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NormalRateFieldNumber                    int IL2CPP_TYPE_I4
    // 018 NormalRate                               ModelClassType GashaNormalRateStatus GashaNormalRateStatus GashaNormalRateStatus Pointer
    // 000 PromisedRateFieldNumber                  int IL2CPP_TYPE_I4
    // 020 PromisedRate                             ModelClassType GashaPromisedRateStatus GashaPromisedRateStatus GashaPromisedRateStatus Pointer
    // 000 StepNoFieldNumber                        int IL2CPP_TYPE_I4
    // 028 StepNo                                   ModelPrimitiveType int int int Int32
    public partial class GashaRateStatus : DataModel
    {
        public GashaNormalRateStatus?                   NormalRate                              { get; set; }
        public GashaPromisedRateStatus?                 PromisedRate                            { get; set; }
        public int                                      StepNo                                  { get; set; }

        public static GashaRateStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaRateStatus() { Pointer= p0 };

            value.NormalRate                                = GetObject<GashaNormalRateStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaNormalRateStatus.FromPointer); // 0x18 NormalRate                  ( ModelClassType GashaNormalRateStatus GashaNormalRateStatus GashaNormalRateStatus Pointer )
            value.PromisedRate                              = GetObject<GashaPromisedRateStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaPromisedRateStatus.FromPointer); // 0x20 PromisedRate                ( ModelClassType GashaPromisedRateStatus GashaPromisedRateStatus GashaPromisedRateStatus Pointer )
            value.StepNo                                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 StepNo                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
