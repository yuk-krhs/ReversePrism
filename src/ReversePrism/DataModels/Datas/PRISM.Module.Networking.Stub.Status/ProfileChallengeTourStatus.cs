using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProfileChallengeTourStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstChallengeTourIdFieldNumber            int IL2CPP_TYPE_I4
    // 018 MstChallengeTourId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 UnitStatusFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_unitStatus_codec               FieldCodec`1<ProfileChallengeTourUnitStatus> IL2CPP_TYPE_GENERICINST
    // 020 UnitStatus                               000185CECD88 ModelClassListType RepeatedField`1<ProfileChallengeTourUnitStatus> RepeatedField`1<ProfileChallengeTourUnitStatus> List<ProfileChallengeTourUnitStatus> Pointer
    public partial class ProfileChallengeTourStatus : DataModel
    {
        public int                                      MstChallengeTourId                      { get; set; }
        public List<ProfileChallengeTourUnitStatus>?    UnitStatus                              { get; set; }

        public static ProfileChallengeTourStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileChallengeTourStatus() { Pointer= p0 };

            value.MstChallengeTourId                        = GetInt32(new IntPtr(p + 0x018)); // 024662684058 0x18 MstChallengeTourId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnitStatus                                = GetObjectList<ProfileChallengeTourUnitStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileChallengeTourUnitStatus.FromPointer); // 0246626840B8 0x20 UnitStatus                  ( 000185CECD88 ModelClassListType RepeatedField`1<ProfileChallengeTourUnitStatus> RepeatedField`1<ProfileChallengeTourUnitStatus> List<ProfileChallengeTourUnitStatus> Pointer )

            return value;
        }
    }
}
