using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PvpOpponentStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 018 MstEventId                               ModelPrimitiveType int int int Int32
    // 000 UserIdFieldNumber                        int IL2CPP_TYPE_I4
    // 020 UserId                                   ModelPrimitiveType string string string String
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 028 Rank                                     ModelPrimitiveType int int int Int32
    // 000 ProfileFieldNumber                       int IL2CPP_TYPE_I4
    // 030 Profile                                  ModelClassType PvpProfileStatus PvpProfileStatus PvpProfileStatus Pointer
    // 000 DefensePvpUnitFieldNumber                int IL2CPP_TYPE_I4
    // 038 DefensePvpUnit                           ModelClassType PvpUnitStatus PvpUnitStatus PvpUnitStatus Pointer
    public partial class PvpOpponentStatus : DataModel
    {
        public int                                      MstEventId                              { get; set; }
        public string                                   UserId                                  { get; set; }
        public int                                      Rank                                    { get; set; }
        public PvpProfileStatus?                        Profile                                 { get; set; }
        public PvpUnitStatus?                           DefensePvpUnit                          { get; set; }

        public static PvpOpponentStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpOpponentStatus() { Pointer= p0 };

            value.MstEventId                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstEventId                  ( ModelPrimitiveType int int int Int32 )
            value.UserId                                    = GetString(new IntPtr(p + 0x020)); // 0x20 UserId                      ( ModelPrimitiveType string string string String )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x028)); // 0x28 Rank                        ( ModelPrimitiveType int int int Int32 )
            value.Profile                                   = GetObject<PvpProfileStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.PvpProfileStatus.FromPointer); // 0x30 Profile                     ( ModelClassType PvpProfileStatus PvpProfileStatus PvpProfileStatus Pointer )
            value.DefensePvpUnit                            = GetObject<PvpUnitStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.PvpUnitStatus.FromPointer); // 0x38 DefensePvpUnit              ( ModelClassType PvpUnitStatus PvpUnitStatus PvpUnitStatus Pointer )

            return value;
        }
    }
}
