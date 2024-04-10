using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ConvertPieceListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 018 HavingGroup                              0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class ConvertPieceListReply : DataModel
    {
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }

        public static ConvertPieceListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConvertPieceListReply() { Pointer= p0 };

            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 02466238BF58 0x18 HavingGroup                 ( 0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
