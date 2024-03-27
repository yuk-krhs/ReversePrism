using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ConvertPieceListArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ConvertPieceListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_convertPieceList_codec         FieldCodec`1<UseProductStatus> IL2CPP_TYPE_GENERICINST
    // 018 ConvertPieceList                         000185CF6978 ModelClassListType RepeatedField`1<UseProductStatus> RepeatedField`1<UseProductStatus> List<UseProductStatus> Pointer
    public partial class ConvertPieceListArgs
    {
        public List<UseProductStatus>?                  ConvertPieceList                        { get; set; }

        public static ConvertPieceListArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConvertPieceListArgs();

            value.ConvertPieceList                          = GetObjectList<UseProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.UseProductStatus.FromPointer); // 0270D23FB460 0x18 ConvertPieceList            ( 000185CF6978 ModelClassListType RepeatedField`1<UseProductStatus> RepeatedField`1<UseProductStatus> List<UseProductStatus> Pointer )

            return value;
        }
    }
}
