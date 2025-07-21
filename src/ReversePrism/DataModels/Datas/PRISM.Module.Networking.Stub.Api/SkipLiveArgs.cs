using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SkipLiveArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSongIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstSongId                                ModelPrimitiveType int int int Int32
    // 000 DifficultyLevelFieldNumber               int IL2CPP_TYPE_I4
    // 01C DifficultyLevel                          ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 000 LiveBoostFieldNumber                     int IL2CPP_TYPE_I4
    // 020 LiveBoost                                ModelPrimitiveType int int int Int32
    // 000 UnitNumberFieldNumber                    int IL2CPP_TYPE_I4
    // 024 UnitNumber                               ModelPrimitiveType int int int Int32
    // 000 SupportIdolListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_supportIdolList_codec          FieldCodec`1<LiveSupportIdolStatus> IL2CPP_TYPE_GENERICINST
    // 028 SupportIdolList                          ModelClassListType RepeatedField`1<LiveSupportIdolStatus> RepeatedField`1<LiveSupportIdolStatus> List<LiveSupportIdolStatus> Pointer
    // 000 StaminaTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 030 StaminaType                              ModelEnumType SkipLiveStaminaType SkipLiveStaminaType SkipLiveStaminaType Int32
    public partial class SkipLiveArgs : DataModel
    {
        public int                                      MstSongId                               { get; set; }
        public SongDifficultyLevel                      DifficultyLevel                         { get; set; }
        public int                                      LiveBoost                               { get; set; }
        public int                                      UnitNumber                              { get; set; }
        public List<LiveSupportIdolStatus>?             SupportIdolList                         { get; set; }
        public SkipLiveStaminaType                      StaminaType                             { get; set; }

        public static SkipLiveArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkipLiveArgs() { Pointer= p0 };

            value.MstSongId                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSongId                   ( ModelPrimitiveType int int int Int32 )
            value.DifficultyLevel                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x01C)); // 0x1C DifficultyLevel             ( ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.LiveBoost                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 LiveBoost                   ( ModelPrimitiveType int int int Int32 )
            value.UnitNumber                                = GetInt32(new IntPtr(p + 0x024)); // 0x24 UnitNumber                  ( ModelPrimitiveType int int int Int32 )
            value.SupportIdolList                           = GetObjectList<LiveSupportIdolStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveSupportIdolStatus.FromPointer); // 0x28 SupportIdolList             ( ModelClassListType RepeatedField`1<LiveSupportIdolStatus> RepeatedField`1<LiveSupportIdolStatus> List<LiveSupportIdolStatus> Pointer )
            value.StaminaType                               = (SkipLiveStaminaType)GetInt32(new IntPtr(p + 0x030)); // 0x30 StaminaType                 ( ModelEnumType SkipLiveStaminaType SkipLiveStaminaType SkipLiveStaminaType Int32 )

            return value;
        }
    }
}
