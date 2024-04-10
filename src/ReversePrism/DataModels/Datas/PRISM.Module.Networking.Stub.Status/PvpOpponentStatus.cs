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
    // 018 MstEventId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 UserIdFieldNumber                        int IL2CPP_TYPE_I4
    // 020 UserId                                   000186671910 ModelPrimitiveType string string string String
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 028 Rank                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ProfileFieldNumber                       int IL2CPP_TYPE_I4
    // 030 Profile                                  0001865EFBB0 ModelClassType PvpProfileStatus PvpProfileStatus PvpProfileStatus Pointer
    // 000 DefensePvpUnitFieldNumber                int IL2CPP_TYPE_I4
    // 038 DefensePvpUnit                           0001865F80B0 ModelClassType PvpUnitStatus PvpUnitStatus PvpUnitStatus Pointer
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

            value.MstEventId                                = GetInt32(new IntPtr(p + 0x018)); // 02466139F6B0 0x18 MstEventId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UserId                                    = GetString(new IntPtr(p + 0x020)); // 02466139F6F0 0x20 UserId                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x028)); // 02466139F730 0x28 Rank                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Profile                                   = GetObject<PvpProfileStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.PvpProfileStatus.FromPointer); // 02466139F770 0x30 Profile                     ( 0001865EFBB0 ModelClassType PvpProfileStatus PvpProfileStatus PvpProfileStatus Pointer )
            value.DefensePvpUnit                            = GetObject<PvpUnitStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.PvpUnitStatus.FromPointer); // 02466139F7B0 0x38 DefensePvpUnit              ( 0001865F80B0 ModelClassType PvpUnitStatus PvpUnitStatus PvpUnitStatus Pointer )

            return value;
        }
    }
}
