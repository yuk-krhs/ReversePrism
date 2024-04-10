using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetProducerEventInfoReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DetailFieldNumber                        int IL2CPP_TYPE_I4
    // 018 Detail                                   0001865B2BF0 ModelClassType ProfileEventDetailStatus ProfileEventDetailStatus ProfileEventDetailStatus Pointer
    public partial class GetProducerEventInfoReply : DataModel
    {
        public ProfileEventDetailStatus?                Detail                                  { get; set; }

        public static GetProducerEventInfoReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetProducerEventInfoReply() { Pointer= p0 };

            value.Detail                                    = GetObject<ProfileEventDetailStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProfileEventDetailStatus.FromPointer); // 024662645A28 0x18 Detail                      ( 0001865B2BF0 ModelClassType ProfileEventDetailStatus ProfileEventDetailStatus ProfileEventDetailStatus Pointer )

            return value;
        }
    }
}
