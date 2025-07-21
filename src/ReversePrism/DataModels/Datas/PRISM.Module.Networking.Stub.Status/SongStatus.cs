using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SongStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSongIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstSongId                                ModelPrimitiveType int int int Int32
    // 000 SongCategoryFieldNumber                  int IL2CPP_TYPE_I4
    // 01C SongCategory                             ModelEnumType SongCategory SongCategory SongCategory Int32
    // 000 DifficultyLevelListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_difficultyLevelList_codec      FieldCodec`1<SongDifficultyLevelStatus> IL2CPP_TYPE_GENERICINST
    // 020 DifficultyLevelList                      ModelClassListType RepeatedField`1<SongDifficultyLevelStatus> RepeatedField`1<SongDifficultyLevelStatus> List<SongDifficultyLevelStatus> Pointer
    // 000 OriginalMemberIdolListFieldNumber        int IL2CPP_TYPE_I4
    // 010 _repeated_originalMemberIdolList_codec   FieldCodec`1<MvIdolStatus> IL2CPP_TYPE_GENERICINST
    // 028 OriginalMemberIdolList                   ModelClassListType RepeatedField`1<MvIdolStatus> RepeatedField`1<MvIdolStatus> List<MvIdolStatus> Pointer
    public partial class SongStatus : DataModel
    {
        public int                                      MstSongId                               { get; set; }
        public SongCategory                             SongCategory                            { get; set; }
        public List<SongDifficultyLevelStatus>?         DifficultyLevelList                     { get; set; }
        public List<MvIdolStatus>?                      OriginalMemberIdolList                  { get; set; }

        public static SongStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SongStatus() { Pointer= p0 };

            value.MstSongId                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSongId                   ( ModelPrimitiveType int int int Int32 )
            value.SongCategory                              = (SongCategory)GetInt32(new IntPtr(p + 0x01C)); // 0x1C SongCategory                ( ModelEnumType SongCategory SongCategory SongCategory Int32 )
            value.DifficultyLevelList                       = GetObjectList<SongDifficultyLevelStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.SongDifficultyLevelStatus.FromPointer); // 0x20 DifficultyLevelList         ( ModelClassListType RepeatedField`1<SongDifficultyLevelStatus> RepeatedField`1<SongDifficultyLevelStatus> List<SongDifficultyLevelStatus> Pointer )
            value.OriginalMemberIdolList                    = GetObjectList<MvIdolStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.MvIdolStatus.FromPointer); // 0x28 OriginalMemberIdolList      ( ModelClassListType RepeatedField`1<MvIdolStatus> RepeatedField`1<MvIdolStatus> List<MvIdolStatus> Pointer )

            return value;
        }
    }
}
