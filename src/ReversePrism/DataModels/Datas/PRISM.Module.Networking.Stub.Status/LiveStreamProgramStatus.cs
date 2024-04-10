using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeginDate                                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<LiveStreamProgramStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstStreamProgramIdFieldNumber            int IL2CPP_TYPE_I4
    // 028 MstStreamProgramId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TitleFieldNumber                         int IL2CPP_TYPE_I4
    // 030 Title                                    000186671910 ModelPrimitiveType string string string String
    // 000 DescriptionFieldNumber                   int IL2CPP_TYPE_I4
    // 038 Description                              000186671910 ModelPrimitiveType string string string String
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 040 _BeginDate                               000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 PerformerIdListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_performerIdList_codec          FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 048 PerformerIdList                          000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 LiveStreamStateFieldNumber               int IL2CPP_TYPE_I4
    // 050 LiveStreamState                          000186583730 ModelEnumType LiveStreamProgramState LiveStreamProgramState LiveStreamProgramState Int32
    public partial class LiveStreamProgramStatus : DataModel
    {
        public DateTime                                 BeginDate                               { get; set; }
        public int                                      MstStreamProgramId                      { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Description                             { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }
        public List<int>?                               PerformerIdList                         { get; set; }
        public LiveStreamProgramState                   LiveStreamState                         { get; set; }

        public static LiveStreamProgramStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveStreamProgramStatus() { Pointer= p0 };

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 024662A4B120 0x10 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstStreamProgramId                        = GetInt32(new IntPtr(p + 0x028)); // 024662A4B1A0 0x28 MstStreamProgramId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Title                                     = GetString(new IntPtr(p + 0x030)); // 024662A4B1E0 0x30 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x038)); // 024662A4B220 0x38 Description                 ( 000186671910 ModelPrimitiveType string string string String )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 024662A4B260 0x40 _BeginDate                  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.PerformerIdList                           = GetInt32List(new IntPtr(p + 0x048)); // 024662A4B2C0 0x48 PerformerIdList             ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.LiveStreamState                           = (LiveStreamProgramState)GetInt32(new IntPtr(p + 0x050)); // 024662A4B300 0x50 LiveStreamState             ( 000186583730 ModelEnumType LiveStreamProgramState LiveStreamProgramState LiveStreamProgramState Int32 )
            value.BeginDate                     = ToDateTime(value._BeginDate);

            return value;
        }
    }
}
