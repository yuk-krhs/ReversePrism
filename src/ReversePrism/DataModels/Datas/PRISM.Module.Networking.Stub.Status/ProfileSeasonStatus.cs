using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeginDate                                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 EndDate                                  000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ProfileSeasonStatus> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSeasonMissionIdFieldNumber            int IL2CPP_TYPE_I4
    // 038 MstSeasonMissionId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 040 _BeginDate                               000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 048 _EndDate                                 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 050 Rank                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IsPremiumFieldNumber                     int IL2CPP_TYPE_I4
    // 054 IsPremium                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProfileSeasonStatus
    {
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public int                                      MstSeasonMissionId                      { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }
        public int                                      Rank                                    { get; set; }
        public bool                                     IsPremium                               { get; set; }

        public static ProfileSeasonStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileSeasonStatus();

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 0270D271C2A8 0x10 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 0270D271C2C8 0x20 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstSeasonMissionId                        = GetInt32(new IntPtr(p + 0x038)); // 0270D271C348 0x38 MstSeasonMissionId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D271C388 0x40 _BeginDate                  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x048), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D271C3C8 0x48 _EndDate                    ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x050)); // 0270D271C408 0x50 Rank                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsPremium                                 = GetBool(new IntPtr(p + 0x054)); // 0270D271C448 0x54 IsPremium                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BeginDate                     = ToDateTime(value._BeginDate);
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}
