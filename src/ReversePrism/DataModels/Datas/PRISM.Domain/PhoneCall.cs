using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstPhoneCallId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 IsUnread                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 PostDate                                 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 TypeId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C ScenarioId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 ScenarioNumber                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 PhoneCallTextList                        000185D040F8 ModelClassListType IReadOnlyList`1<IPhoneCallTextStatus> IReadOnlyList`1<IPhoneCallTextStatus> List<IPhoneCallTextStatus> Pointer
    // 000 EmptyArray                               PhoneCall[] IL2CPP_TYPE_SZARRAY
    public partial class PhoneCall : DataModel
    {
        public int                                      MstPhoneCallId                          { get; set; }
        public bool                                     IsUnread                                { get; set; }
        public DateTime                                 PostDate                                { get; set; }
        public int                                      TypeId                                  { get; set; }
        public int                                      ScenarioId                              { get; set; }
        public int                                      ScenarioNumber                          { get; set; }
        public List<IPhoneCallTextStatus>?              PhoneCallTextList                       { get; set; }

        public static PhoneCall? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PhoneCall() { Pointer= p0 };

            value.MstPhoneCallId                            = GetInt32(new IntPtr(p + 0x010)); // 0245A5F300E8 0x10 MstPhoneCallId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x014)); // 0245A5F30108 0x14 IsUnread                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PostDate                                  = GetDateTime(new IntPtr(p + 0x018)); // 0245A5F30128 0x18 PostDate                    ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.TypeId                                    = GetInt32(new IntPtr(p + 0x028)); // 0245A5F30148 0x28 TypeId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScenarioId                                = GetInt32(new IntPtr(p + 0x02C)); // 0245A5F30168 0x2C ScenarioId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScenarioNumber                            = GetInt32(new IntPtr(p + 0x030)); // 0245A5F30188 0x30 ScenarioNumber              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PhoneCallTextList                         = GetObjectList<IPhoneCallTextStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPhoneCallTextStatus.FromPointer); // 0245A5F301A8 0x38 PhoneCallTextList           ( 000185D040F8 ModelClassListType IReadOnlyList`1<IPhoneCallTextStatus> IReadOnlyList`1<IPhoneCallTextStatus> List<IPhoneCallTextStatus> Pointer )

            return value;
        }
    }
}
