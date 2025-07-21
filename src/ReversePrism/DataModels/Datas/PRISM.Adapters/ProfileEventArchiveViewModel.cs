using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Status                                   ModelClassType IUserProfileEventStatus IUserProfileEventStatus IUserProfileEventStatus Pointer
    // 018 StartDateTimeText                        ModelPrimitiveType string string string String
    // 020 EndDateTimeText                          ModelPrimitiveType string string string String
    // 028 <TextKey>k__BackingField                 ValueTuple`2<string, int> IL2CPP_TYPE_GENERICINST
    // 038 IconId                                   ModelPrimitiveType int int int Int32
    public partial class ProfileEventArchiveViewModel : DataModel
    {
        public IUserProfileEventStatus?                 Status                                  { get; set; }
        public string                                   StartDateTimeText                       { get; set; }
        public string                                   EndDateTimeText                         { get; set; }
        public int                                      IconId                                  { get; set; }

        public static ProfileEventArchiveViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileEventArchiveViewModel() { Pointer= p0 };

            value.Status                                    = GetObject<IUserProfileEventStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IUserProfileEventStatus.FromPointer); // 0x10 Status                      ( ModelClassType IUserProfileEventStatus IUserProfileEventStatus IUserProfileEventStatus Pointer )
            value.StartDateTimeText                         = GetString(new IntPtr(p + 0x018)); // 0x18 StartDateTimeText           ( ModelPrimitiveType string string string String )
            value.EndDateTimeText                           = GetString(new IntPtr(p + 0x020)); // 0x20 EndDateTimeText             ( ModelPrimitiveType string string string String )
            value.IconId                                    = GetInt32(new IntPtr(p + 0x038)); // 0x38 IconId                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
