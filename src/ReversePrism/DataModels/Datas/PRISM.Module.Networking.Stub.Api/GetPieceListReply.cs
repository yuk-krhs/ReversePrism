using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetPieceListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PieceListFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_pieceList_codec                FieldCodec`1<HavingProductStatus> IL2CPP_TYPE_GENERICINST
    // 018 PieceList                                ModelClassListType RepeatedField`1<HavingProductStatus> RepeatedField`1<HavingProductStatus> List<HavingProductStatus> Pointer
    public partial class GetPieceListReply : DataModel
    {
        public List<HavingProductStatus>?               PieceList                               { get; set; }

        public static GetPieceListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetPieceListReply() { Pointer= p0 };

            value.PieceList                                 = GetObjectList<HavingProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.HavingProductStatus.FromPointer); // 0x18 PieceList                   ( ModelClassListType RepeatedField`1<HavingProductStatus> RepeatedField`1<HavingProductStatus> List<HavingProductStatus> Pointer )

            return value;
        }
    }
}
