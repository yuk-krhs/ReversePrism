using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<IdolBaseResultStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IdolLevelFieldNumber                     int IL2CPP_TYPE_I4
    // 018 IdolLevel                                ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 IdolLevelExpFieldNumber                  int IL2CPP_TYPE_I4
    // 020 IdolLevelExp                             ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 DearnessLevelFieldNumber                 int IL2CPP_TYPE_I4
    // 028 DearnessLevel                            ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 DearnessLevelExpFieldNumber              int IL2CPP_TYPE_I4
    // 030 DearnessLevelExp                         ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 FanFieldNumber                           int IL2CPP_TYPE_I4
    // 038 Fan                                      ModelPrimitiveType long long long Int64
    // 000 ParameterFieldNumber                     int IL2CPP_TYPE_I4
    // 040 Parameter                                ModelClassType IdolParameterStatus IdolParameterStatus IdolParameterStatus Pointer
    public partial class IdolBaseResultStatus : DataModel
    {
        public LimitedValueStatus?                      IdolLevel                               { get; set; }
        public LimitedValueStatus?                      IdolLevelExp                            { get; set; }
        public LimitedValueStatus?                      DearnessLevel                           { get; set; }
        public LimitedValueStatus?                      DearnessLevelExp                        { get; set; }
        public long                                     Fan                                     { get; set; }
        public IdolParameterStatus?                     Parameter                               { get; set; }

        public static IdolBaseResultStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseResultStatus() { Pointer= p0 };

            value.IdolLevel                                 = GetObject<LimitedValueStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0x18 IdolLevel                   ( ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.IdolLevelExp                              = GetObject<LimitedValueStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0x20 IdolLevelExp                ( ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.DearnessLevel                             = GetObject<LimitedValueStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0x28 DearnessLevel               ( ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.DearnessLevelExp                          = GetObject<LimitedValueStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0x30 DearnessLevelExp            ( ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.Fan                                       = GetInt64(new IntPtr(p + 0x038)); // 0x38 Fan                         ( ModelPrimitiveType long long long Int64 )
            value.Parameter                                 = GetObject<IdolParameterStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IdolParameterStatus.FromPointer); // 0x40 Parameter                   ( ModelClassType IdolParameterStatus IdolParameterStatus IdolParameterStatus Pointer )

            return value;
        }
    }
}
