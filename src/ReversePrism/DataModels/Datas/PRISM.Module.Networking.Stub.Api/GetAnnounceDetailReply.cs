using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetAnnounceDetailReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 AnnounceDetailFieldNumber                int IL2CPP_TYPE_I4
    // 018 AnnounceDetail                           ModelClassType AnnounceDetailStatus AnnounceDetailStatus AnnounceDetailStatus Pointer
    public partial class GetAnnounceDetailReply : DataModel
    {
        public AnnounceDetailStatus?                    AnnounceDetail                          { get; set; }

        public static GetAnnounceDetailReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetAnnounceDetailReply() { Pointer= p0 };

            value.AnnounceDetail                            = GetObject<AnnounceDetailStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.AnnounceDetailStatus.FromPointer); // 0x18 AnnounceDetail              ( ModelClassType AnnounceDetailStatus AnnounceDetailStatus AnnounceDetailStatus Pointer )

            return value;
        }
    }
}
