using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SubSeasonListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 MstSubSeasonIdListFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_mstSubSeasonIdList_codec       FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 020 MstSubSeasonIdList                       000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class SubSeasonListReply
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public List<int>?                               MstSubSeasonIdList                      { get; set; }

        public static SubSeasonListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubSeasonListReply();

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0270D25DB4B0 0x18 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.MstSubSeasonIdList                        = GetInt32List(new IntPtr(p + 0x020)); // 0270D25DB510 0x20 MstSubSeasonIdList          ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
