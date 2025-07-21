using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeginDate                                ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<LiveStreamProgramStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstStreamProgramIdFieldNumber            int IL2CPP_TYPE_I4
    // 028 MstStreamProgramId                       ModelPrimitiveType int int int Int32
    // 000 TitleFieldNumber                         int IL2CPP_TYPE_I4
    // 030 Title                                    ModelPrimitiveType string string string String
    // 000 DescriptionFieldNumber                   int IL2CPP_TYPE_I4
    // 038 Description                              ModelPrimitiveType string string string String
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 040 _BeginDate                               ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 PerformerIdListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_performerIdList_codec          FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 048 PerformerIdList                          ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 LiveStreamStateFieldNumber               int IL2CPP_TYPE_I4
    // 050 LiveStreamState                          ModelEnumType LiveStreamProgramState LiveStreamProgramState LiveStreamProgramState Int32
    // 000 IsPremiumFieldNumber                     int IL2CPP_TYPE_I4
    // 054 IsPremium                                ModelPrimitiveType bool bool bool Bool
    public partial class LiveStreamProgramStatus : DataModel
    {
        public DateTime                                 BeginDate                               { get; set; }
        public int                                      MstStreamProgramId                      { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Description                             { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }
        public List<int>?                               PerformerIdList                         { get; set; }
        public LiveStreamProgramState                   LiveStreamState                         { get; set; }
        public bool                                     IsPremium                               { get; set; }

        public static LiveStreamProgramStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveStreamProgramStatus() { Pointer= p0 };

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 0x10 BeginDate                   ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstStreamProgramId                        = GetInt32(new IntPtr(p + 0x028)); // 0x28 MstStreamProgramId          ( ModelPrimitiveType int int int Int32 )
            value.Title                                     = GetString(new IntPtr(p + 0x030)); // 0x30 Title                       ( ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x038)); // 0x38 Description                 ( ModelPrimitiveType string string string String )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 0x40 _BeginDate                  ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.PerformerIdList                           = GetInt32List(new IntPtr(p + 0x048)); // 0x48 PerformerIdList             ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.LiveStreamState                           = (LiveStreamProgramState)GetInt32(new IntPtr(p + 0x050)); // 0x50 LiveStreamState             ( ModelEnumType LiveStreamProgramState LiveStreamProgramState LiveStreamProgramState Int32 )
            value.IsPremium                                 = GetBool(new IntPtr(p + 0x054)); // 0x54 IsPremium                   ( ModelPrimitiveType bool bool bool Bool )
            value.BeginDate                     = ToDateTime(value._BeginDate);

            return value;
        }
    }
}
