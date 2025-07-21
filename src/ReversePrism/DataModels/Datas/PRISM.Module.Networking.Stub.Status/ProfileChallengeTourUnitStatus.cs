using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProfileChallengeTourUnitStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UnitIdFieldNumber                        int IL2CPP_TYPE_I4
    // 018 UnitId                                   ModelPrimitiveType int int int Int32
    // 000 StageFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Stage                                    ModelPrimitiveType int int int Int32
    // 000 PointFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Point                                    ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    public partial class ProfileChallengeTourUnitStatus : DataModel
    {
        public int                                      UnitId                                  { get; set; }
        public int                                      Stage                                   { get; set; }
        public LimitedValueStatus?                      Point                                   { get; set; }

        public static ProfileChallengeTourUnitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileChallengeTourUnitStatus() { Pointer= p0 };

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.Stage                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Stage                       ( ModelPrimitiveType int int int Int32 )
            value.Point                                     = GetObject<LimitedValueStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0x20 Point                       ( ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )

            return value;
        }
    }
}
