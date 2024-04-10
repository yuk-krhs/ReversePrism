using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PostDate                                 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ChainTalkStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UsersFieldNumber                         int IL2CPP_TYPE_I4
    // 008 _repeated_users_codec                    FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 028 Users                                    000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 IsUnreadFieldNumber                      int IL2CPP_TYPE_I4
    // 030 IsUnread                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 ChoiceFieldNumber                        int IL2CPP_TYPE_I4
    // 010 _repeated_choice_codec                   FieldCodec`1<ChainChoiceStatus> IL2CPP_TYPE_GENERICINST
    // 038 Choice                                   000185CD0648 ModelClassListType RepeatedField`1<ChainChoiceStatus> RepeatedField`1<ChainChoiceStatus> List<ChainChoiceStatus> Pointer
    // 000 PostDateFieldNumber                      int IL2CPP_TYPE_I4
    // 040 _PostDate                                000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 GroupTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 048 GroupType                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ChainTalkTextListFieldNumber             int IL2CPP_TYPE_I4
    // 018 _repeated_chainTalkTextList_codec        FieldCodec`1<ChainTalkTextStatus> IL2CPP_TYPE_GENERICINST
    // 050 ChainTalkTextList                        000185CD0B58 ModelClassListType RepeatedField`1<ChainTalkTextStatus> RepeatedField`1<ChainTalkTextStatus> List<ChainTalkTextStatus> Pointer
    public partial class ChainTalkStatus : DataModel
    {
        public DateTime                                 PostDate                                { get; set; }
        public List<int>?                               Users                                   { get; set; }
        public bool                                     IsUnread                                { get; set; }
        public List<ChainChoiceStatus>?                 Choice                                  { get; set; }
        public Timestamp?                               _PostDate                               { get; set; }
        public int                                      GroupType                               { get; set; }
        public List<ChainTalkTextStatus>?               ChainTalkTextList                       { get; set; }

        public static ChainTalkStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkStatus() { Pointer= p0 };

            value.PostDate                                  = GetDateTime(new IntPtr(p + 0x010)); // 02466227F300 0x10 PostDate                    ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.Users                                     = GetInt32List(new IntPtr(p + 0x028)); // 02466227F3A0 0x28 Users                       ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x030)); // 02466227F3E0 0x30 IsUnread                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Choice                                    = GetObjectList<ChainChoiceStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChainChoiceStatus.FromPointer); // 02466227F440 0x38 Choice                      ( 000185CD0648 ModelClassListType RepeatedField`1<ChainChoiceStatus> RepeatedField`1<ChainChoiceStatus> List<ChainChoiceStatus> Pointer )
            value._PostDate                                 = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 02466227F480 0x40 _PostDate                   ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.GroupType                                 = GetInt32(new IntPtr(p + 0x048)); // 02466227F4C0 0x48 GroupType                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ChainTalkTextList                         = GetObjectList<ChainTalkTextStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ChainTalkTextStatus.FromPointer); // 02466227F520 0x50 ChainTalkTextList           ( 000185CD0B58 ModelClassListType RepeatedField`1<ChainTalkTextStatus> RepeatedField`1<ChainTalkTextStatus> List<ChainTalkTextStatus> Pointer )
            value.PostDate                      = ToDateTime(value._PostDate);

            return value;
        }
    }
}
