using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetIdolBaseListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IdolBaseListFieldNumber                  int IL2CPP_TYPE_I4
    // 008 _repeated_idolBaseList_codec             FieldCodec`1<IdolBaseStatus> IL2CPP_TYPE_GENERICINST
    // 018 IdolBaseList                             000185CDF648 ModelClassListType RepeatedField`1<IdolBaseStatus> RepeatedField`1<IdolBaseStatus> List<IdolBaseStatus> Pointer
    public partial class GetIdolBaseListReply : DataModel
    {
        public List<IdolBaseStatus>?                    IdolBaseList                            { get; set; }

        public static GetIdolBaseListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetIdolBaseListReply() { Pointer= p0 };

            value.IdolBaseList                              = GetObjectList<IdolBaseStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IdolBaseStatus.FromPointer); // 02466206A978 0x18 IdolBaseList                ( 000185CDF648 ModelClassListType RepeatedField`1<IdolBaseStatus> RepeatedField`1<IdolBaseStatus> List<IdolBaseStatus> Pointer )

            return value;
        }
    }
}
