using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ReceivePresentReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PresentListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_presentList_codec              FieldCodec`1<PresentStatus> IL2CPP_TYPE_GENERICINST
    // 018 PresentList                              000185CE9CA8 ModelClassListType RepeatedField`1<PresentStatus> RepeatedField`1<PresentStatus> List<PresentStatus> Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 020 HavingGroup                              0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class ReceivePresentReply : DataModel
    {
        public List<PresentStatus>?                     PresentList                             { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }

        public static ReceivePresentReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceivePresentReply() { Pointer= p0 };

            value.PresentList                               = GetObjectList<PresentStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.PresentStatus.FromPointer); // 0246623FA4C0 0x18 PresentList                 ( 000185CE9CA8 ModelClassListType RepeatedField`1<PresentStatus> RepeatedField`1<PresentStatus> List<PresentStatus> Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0246623FA500 0x20 HavingGroup                 ( 0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
