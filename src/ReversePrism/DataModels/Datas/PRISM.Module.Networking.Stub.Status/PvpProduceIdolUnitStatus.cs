using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PvpProduceIdolUnitStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ProduceIdolListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_produceIdolList_codec          FieldCodec`1<ProduceIdolStatus> IL2CPP_TYPE_GENERICINST
    // 020 ProduceIdolList                          000185CEBD88 ModelClassListType RepeatedField`1<ProduceIdolStatus> RepeatedField`1<ProduceIdolStatus> List<ProduceIdolStatus> Pointer
    // 000 IdolBaseListFieldNumber                  int IL2CPP_TYPE_I4
    // 010 _repeated_idolBaseList_codec             FieldCodec`1<IdolBaseStatus> IL2CPP_TYPE_GENERICINST
    // 028 IdolBaseList                             000185CDF648 ModelClassListType RepeatedField`1<IdolBaseStatus> RepeatedField`1<IdolBaseStatus> List<IdolBaseStatus> Pointer
    // 000 CardDeckFieldNumber                      int IL2CPP_TYPE_I4
    // 030 CardDeck                                 000186536800 ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer
    public partial class PvpProduceIdolUnitStatus : DataModel
    {
        public int                                      MstUnitId                               { get; set; }
        public List<ProduceIdolStatus>?                 ProduceIdolList                         { get; set; }
        public List<IdolBaseStatus>?                    IdolBaseList                            { get; set; }
        public ProduceCardDeckStatus?                   CardDeck                                { get; set; }

        public static PvpProduceIdolUnitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpProduceIdolUnitStatus() { Pointer= p0 };

            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x018)); // 0246613A1F70 0x18 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProduceIdolList                           = GetObjectList<ProduceIdolStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceIdolStatus.FromPointer); // 0246613A1FD0 0x20 ProduceIdolList             ( 000185CEBD88 ModelClassListType RepeatedField`1<ProduceIdolStatus> RepeatedField`1<ProduceIdolStatus> List<ProduceIdolStatus> Pointer )
            value.IdolBaseList                              = GetObjectList<IdolBaseStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolBaseStatus.FromPointer); // 0246613A2030 0x28 IdolBaseList                ( 000185CDF648 ModelClassListType RepeatedField`1<IdolBaseStatus> RepeatedField`1<IdolBaseStatus> List<IdolBaseStatus> Pointer )
            value.CardDeck                                  = GetObject<ProduceCardDeckStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceCardDeckStatus.FromPointer); // 0246613A2070 0x30 CardDeck                    ( 000186536800 ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer )

            return value;
        }
    }
}
