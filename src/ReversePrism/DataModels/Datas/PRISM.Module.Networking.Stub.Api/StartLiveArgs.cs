using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StartLiveArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSongIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstSongId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DifficultyLevelFieldNumber               int IL2CPP_TYPE_I4
    // 01C DifficultyLevel                          000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 000 StartTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 020 StartType                                000186582F90 ModelEnumType LiveStartType LiveStartType LiveStartType Int32
    // 000 LiveBoostFieldNumber                     int IL2CPP_TYPE_I4
    // 024 LiveBoost                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 UnitNumberFieldNumber                    int IL2CPP_TYPE_I4
    // 028 UnitNumber                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SupportIdolListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_supportIdolList_codec          FieldCodec`1<LiveSupportIdolStatus> IL2CPP_TYPE_GENERICINST
    // 030 SupportIdolList                          000185CE3E48 ModelClassListType RepeatedField`1<LiveSupportIdolStatus> RepeatedField`1<LiveSupportIdolStatus> List<LiveSupportIdolStatus> Pointer
    // 000 DeviceTokenFieldNumber                   int IL2CPP_TYPE_I4
    // 038 DeviceToken                              000186671910 ModelPrimitiveType string string string String
    public partial class StartLiveArgs
    {
        public int                                      MstSongId                               { get; set; }
        public SongDifficultyLevel                      DifficultyLevel                         { get; set; }
        public LiveStartType                            StartType                               { get; set; }
        public int                                      LiveBoost                               { get; set; }
        public int                                      UnitNumber                              { get; set; }
        public List<LiveSupportIdolStatus>?             SupportIdolList                         { get; set; }
        public string                                   DeviceToken                             { get; set; }

        public static StartLiveArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartLiveArgs();

            value.MstSongId                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D21FA750 0x18 MstSongId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DifficultyLevel                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x01C)); // 0270D21FA790 0x1C DifficultyLevel             ( 000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.StartType                                 = (LiveStartType)GetInt32(new IntPtr(p + 0x020)); // 0270D21FA7D0 0x20 StartType                   ( 000186582F90 ModelEnumType LiveStartType LiveStartType LiveStartType Int32 )
            value.LiveBoost                                 = GetInt32(new IntPtr(p + 0x024)); // 0270D21FA810 0x24 LiveBoost                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnitNumber                                = GetInt32(new IntPtr(p + 0x028)); // 0270D21FA850 0x28 UnitNumber                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SupportIdolList                           = GetObjectList<LiveSupportIdolStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveSupportIdolStatus.FromPointer); // 0270D21FA8B0 0x30 SupportIdolList             ( 000185CE3E48 ModelClassListType RepeatedField`1<LiveSupportIdolStatus> RepeatedField`1<LiveSupportIdolStatus> List<LiveSupportIdolStatus> Pointer )
            value.DeviceToken                               = GetString(new IntPtr(p + 0x038)); // 0270D21FA8F0 0x38 DeviceToken                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
