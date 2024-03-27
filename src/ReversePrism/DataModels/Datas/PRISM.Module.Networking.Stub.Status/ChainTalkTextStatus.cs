using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ChainTalkTextStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstChainTalkTextIdFieldNumber            int IL2CPP_TYPE_I4
    // 018 MstChainTalkTextId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstChainUserIdFieldNumber                int IL2CPP_TYPE_I4
    // 01C MstChainUserId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 NextTalkTextIdListFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_nextTalkTextIdList_codec       FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 020 NextTalkTextIdList                       000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 ThinkingRateFieldNumber                  int IL2CPP_TYPE_I4
    // 028 ThinkingRate                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TypingRateFieldNumber                    int IL2CPP_TYPE_I4
    // 02C TypingRate                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TextTypeFieldNumber                      int IL2CPP_TYPE_I4
    // 030 TextType                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ChainTalkTextStatus
    {
        public int                                      MstChainTalkTextId                      { get; set; }
        public int                                      MstChainUserId                          { get; set; }
        public List<int>?                               NextTalkTextIdList                      { get; set; }
        public int                                      ThinkingRate                            { get; set; }
        public int                                      TypingRate                              { get; set; }
        public int                                      TextType                                { get; set; }

        public static ChainTalkTextStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkTextStatus();

            value.MstChainTalkTextId                        = GetInt32(new IntPtr(p + 0x018)); // 0270D2308E88 0x18 MstChainTalkTextId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstChainUserId                            = GetInt32(new IntPtr(p + 0x01C)); // 0270D2308EC8 0x1C MstChainUserId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NextTalkTextIdList                        = GetInt32List(new IntPtr(p + 0x020)); // 0270D2308F28 0x20 NextTalkTextIdList          ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.ThinkingRate                              = GetInt32(new IntPtr(p + 0x028)); // 0270D2308F68 0x28 ThinkingRate                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TypingRate                                = GetInt32(new IntPtr(p + 0x02C)); // 0270D2308FA8 0x2C TypingRate                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TextType                                  = GetInt32(new IntPtr(p + 0x030)); // 0270D2308FE8 0x30 TextType                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
