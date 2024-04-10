using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PreparePvpOpponentListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 018 MstEventId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 01C Rank                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 OpponentListFieldNumber                  int IL2CPP_TYPE_I4
    // 008 _repeated_opponentList_codec             FieldCodec`1<PvpOpponentStatus> IL2CPP_TYPE_GENERICINST
    // 020 OpponentList                             000185CEDC28 ModelClassListType RepeatedField`1<PvpOpponentStatus> RepeatedField`1<PvpOpponentStatus> List<PvpOpponentStatus> Pointer
    public partial class PreparePvpOpponentListReply : DataModel
    {
        public int                                      MstEventId                              { get; set; }
        public int                                      Rank                                    { get; set; }
        public List<PvpOpponentStatus>?                 OpponentList                            { get; set; }

        public static PreparePvpOpponentListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PreparePvpOpponentListReply() { Pointer= p0 };

            value.MstEventId                                = GetInt32(new IntPtr(p + 0x018)); // 0246626C0C70 0x18 MstEventId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x01C)); // 0246626C0CB0 0x1C Rank                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OpponentList                              = GetObjectList<PvpOpponentStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpOpponentStatus.FromPointer); // 0246626C0D10 0x20 OpponentList                ( 000185CEDC28 ModelClassListType RepeatedField`1<PvpOpponentStatus> RepeatedField`1<PvpOpponentStatus> List<PvpOpponentStatus> Pointer )

            return value;
        }
    }
}
