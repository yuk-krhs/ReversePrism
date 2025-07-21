using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetSelfProfileReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProfileFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Profile                                  ModelClassType UserProfileStatus UserProfileStatus UserProfileStatus Pointer
    public partial class SetSelfProfileReply : DataModel
    {
        public UserProfileStatus?                       Profile                                 { get; set; }

        public static SetSelfProfileReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetSelfProfileReply() { Pointer= p0 };

            value.Profile                                   = GetObject<UserProfileStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.UserProfileStatus.FromPointer); // 0x18 Profile                     ( ModelClassType UserProfileStatus UserProfileStatus UserProfileStatus Pointer )

            return value;
        }
    }
}
