using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PostDate                                 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<PhoneCallStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstPhoneCallIdFieldNumber                int IL2CPP_TYPE_I4
    // 028 MstPhoneCallId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IsUnreadFieldNumber                      int IL2CPP_TYPE_I4
    // 02C IsUnread                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 PostDateFieldNumber                      int IL2CPP_TYPE_I4
    // 030 _PostDate                                000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 TypeIdFieldNumber                        int IL2CPP_TYPE_I4
    // 038 TypeId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ScenarioIdFieldNumber                    int IL2CPP_TYPE_I4
    // 03C ScenarioId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ScenarioNumberFieldNumber                int IL2CPP_TYPE_I4
    // 040 ScenarioNumber                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 PhoneCallTextListFieldNumber             int IL2CPP_TYPE_I4
    // 008 _repeated_phoneCallTextList_codec        FieldCodec`1<PhoneCallTextStatus> IL2CPP_TYPE_GENERICINST
    // 048 PhoneCallTextList                        000185CE8A68 ModelClassListType RepeatedField`1<PhoneCallTextStatus> RepeatedField`1<PhoneCallTextStatus> List<PhoneCallTextStatus> Pointer
    public partial class PhoneCallStatus : DataModel
    {
        public DateTime                                 PostDate                                { get; set; }
        public int                                      MstPhoneCallId                          { get; set; }
        public bool                                     IsUnread                                { get; set; }
        public Timestamp?                               _PostDate                               { get; set; }
        public int                                      TypeId                                  { get; set; }
        public int                                      ScenarioId                              { get; set; }
        public int                                      ScenarioNumber                          { get; set; }
        public List<PhoneCallTextStatus>?               PhoneCallTextList                       { get; set; }

        public static PhoneCallStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PhoneCallStatus() { Pointer= p0 };

            value.PostDate                                  = GetDateTime(new IntPtr(p + 0x010)); // 02466228AEE8 0x10 PostDate                    ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstPhoneCallId                            = GetInt32(new IntPtr(p + 0x028)); // 02466228AF68 0x28 MstPhoneCallId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x02C)); // 02466228AFA8 0x2C IsUnread                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value._PostDate                                 = GetObject<Timestamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.Timestamp.FromPointer); // 02466228AFE8 0x30 _PostDate                   ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.TypeId                                    = GetInt32(new IntPtr(p + 0x038)); // 02466228B028 0x38 TypeId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScenarioId                                = GetInt32(new IntPtr(p + 0x03C)); // 02466228B068 0x3C ScenarioId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScenarioNumber                            = GetInt32(new IntPtr(p + 0x040)); // 02466228B0A8 0x40 ScenarioNumber              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PhoneCallTextList                         = GetObjectList<PhoneCallTextStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.PhoneCallTextStatus.FromPointer); // 02466228B108 0x48 PhoneCallTextList           ( 000185CE8A68 ModelClassListType RepeatedField`1<PhoneCallTextStatus> RepeatedField`1<PhoneCallTextStatus> List<PhoneCallTextStatus> Pointer )
            value.PostDate                      = ToDateTime(value._PostDate);

            return value;
        }
    }
}
