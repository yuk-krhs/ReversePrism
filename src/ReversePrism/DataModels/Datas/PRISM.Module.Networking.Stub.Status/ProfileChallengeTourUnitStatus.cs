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
    // 018 UnitId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 StageFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Stage                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 PointFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Point                                    00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    public partial class ProfileChallengeTourUnitStatus
    {
        public int                                      UnitId                                  { get; set; }
        public int                                      Stage                                   { get; set; }
        public LimitedValueStatus?                      Point                                   { get; set; }

        public static ProfileChallengeTourUnitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileChallengeTourUnitStatus();

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D2718A50 0x18 UnitId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Stage                                     = GetInt32(new IntPtr(p + 0x01C)); // 0270D2718A90 0x1C Stage                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Point                                     = GetObject<LimitedValueStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0270D2718AD0 0x20 Point                       ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )

            return value;
        }
    }
}
