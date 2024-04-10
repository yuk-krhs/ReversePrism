using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceMVReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 CsidListFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_csidList_codec                 FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 020 CsidList                                 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 IsArEffectFieldNumber                    int IL2CPP_TYPE_I4
    // 028 IsArEffect                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 FesUnitRankFieldNumber                   int IL2CPP_TYPE_I4
    // 02C FesUnitRank                              000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    public partial class ProduceMVReply : DataModel
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public List<string>?                            CsidList                                { get; set; }
        public bool                                     IsArEffect                              { get; set; }
        public ProduceParameterRank                     FesUnitRank                             { get; set; }

        public static ProduceMVReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceMVReply() { Pointer= p0 };

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 024662556328 0x18 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.CsidList                                  = GetStringList(new IntPtr(p + 0x020)); // 024662556388 0x20 CsidList                    ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.IsArEffect                                = GetBool(new IntPtr(p + 0x028)); // 0246625563C8 0x28 IsArEffect                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FesUnitRank                               = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x02C)); // 024662556408 0x2C FesUnitRank                 ( 000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )

            return value;
        }
    }
}
