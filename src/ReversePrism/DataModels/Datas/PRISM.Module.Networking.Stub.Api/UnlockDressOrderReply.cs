using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<UnlockDressOrderReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 018 HavingGroup                              ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class UnlockDressOrderReply : DataModel
    {
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }

        public static UnlockDressOrderReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnlockDressOrderReply() { Pointer= p0 };

            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0x18 HavingGroup                 ( ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
