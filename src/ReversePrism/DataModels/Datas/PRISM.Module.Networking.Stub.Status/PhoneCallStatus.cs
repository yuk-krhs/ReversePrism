using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PostDate                                 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<PhoneCallStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstPhoneCallIdFieldNumber                int IL2CPP_TYPE_I4
    // 028 MstPhoneCallId                           ModelPrimitiveType int int int Int32
    // 000 IsUnreadFieldNumber                      int IL2CPP_TYPE_I4
    // 02C IsUnread                                 ModelPrimitiveType bool bool bool Bool
    // 000 PostDateFieldNumber                      int IL2CPP_TYPE_I4
    // 030 _PostDate                                ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 TypeIdFieldNumber                        int IL2CPP_TYPE_I4
    // 038 TypeId                                   ModelPrimitiveType int int int Int32
    // 000 ScenarioIdFieldNumber                    int IL2CPP_TYPE_I4
    // 03C ScenarioId                               ModelPrimitiveType int int int Int32
    // 000 ScenarioNumberFieldNumber                int IL2CPP_TYPE_I4
    // 040 ScenarioNumber                           ModelPrimitiveType int int int Int32
    // 000 PhoneCallTextListFieldNumber             int IL2CPP_TYPE_I4
    // 008 _repeated_phoneCallTextList_codec        FieldCodec`1<PhoneCallTextStatus> IL2CPP_TYPE_GENERICINST
    // 048 PhoneCallTextList                        ModelClassListType RepeatedField`1<PhoneCallTextStatus> RepeatedField`1<PhoneCallTextStatus> List<PhoneCallTextStatus> Pointer
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

            value.PostDate                                  = GetDateTime(new IntPtr(p + 0x010)); // 0x10 PostDate                    ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstPhoneCallId                            = GetInt32(new IntPtr(p + 0x028)); // 0x28 MstPhoneCallId              ( ModelPrimitiveType int int int Int32 )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x02C)); // 0x2C IsUnread                    ( ModelPrimitiveType bool bool bool Bool )
            value._PostDate                                 = GetObject<Timestamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.Timestamp.FromPointer); // 0x30 _PostDate                   ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.TypeId                                    = GetInt32(new IntPtr(p + 0x038)); // 0x38 TypeId                      ( ModelPrimitiveType int int int Int32 )
            value.ScenarioId                                = GetInt32(new IntPtr(p + 0x03C)); // 0x3C ScenarioId                  ( ModelPrimitiveType int int int Int32 )
            value.ScenarioNumber                            = GetInt32(new IntPtr(p + 0x040)); // 0x40 ScenarioNumber              ( ModelPrimitiveType int int int Int32 )
            value.PhoneCallTextList                         = GetObjectList<PhoneCallTextStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.PhoneCallTextStatus.FromPointer); // 0x48 PhoneCallTextList           ( ModelClassListType RepeatedField`1<PhoneCallTextStatus> RepeatedField`1<PhoneCallTextStatus> List<PhoneCallTextStatus> Pointer )
            value.PostDate                      = ToDateTime(value._PostDate);

            return value;
        }
    }
}
