using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EpisodeStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEpisodeIdFieldNumber                  int IL2CPP_TYPE_I4
    // 018 MstEpisodeId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 01C MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 StaminaFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Stamina                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 EpisodeStateTypeFieldNumber              int IL2CPP_TYPE_I4
    // 024 EpisodeStateType                         000186741BC0 ModelEnumType EpisodeStateType EpisodeStateType EpisodeStateType Int32
    // 000 DifficultyListFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_difficultyList_codec           FieldCodec`1<EpisodeDifficultyStatus> IL2CPP_TYPE_GENERICINST
    // 028 DifficultyList                           000185CD4BB8 ModelClassListType RepeatedField`1<EpisodeDifficultyStatus> RepeatedField`1<EpisodeDifficultyStatus> List<EpisodeDifficultyStatus> Pointer
    // 000 ChapterFieldNumber                       int IL2CPP_TYPE_I4
    // 030 Chapter                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class EpisodeStatus : DataModel
    {
        public int                                      MstEpisodeId                            { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public int                                      Stamina                                 { get; set; }
        public EpisodeStateType                         EpisodeStateType                        { get; set; }
        public List<EpisodeDifficultyStatus>?           DifficultyList                          { get; set; }
        public int                                      Chapter                                 { get; set; }

        public static EpisodeStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EpisodeStatus() { Pointer= p0 };

            value.MstEpisodeId                              = GetInt32(new IntPtr(p + 0x018)); // 024661040E50 0x18 MstEpisodeId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x01C)); // 024661040E90 0x1C MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Stamina                                   = GetInt32(new IntPtr(p + 0x020)); // 024661040ED0 0x20 Stamina                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EpisodeStateType                          = (EpisodeStateType)GetInt32(new IntPtr(p + 0x024)); // 024661040F10 0x24 EpisodeStateType            ( 000186741BC0 ModelEnumType EpisodeStateType EpisodeStateType EpisodeStateType Int32 )
            value.DifficultyList                            = GetObjectList<EpisodeDifficultyStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.EpisodeDifficultyStatus.FromPointer); // 024661040F70 0x28 DifficultyList              ( 000185CD4BB8 ModelClassListType RepeatedField`1<EpisodeDifficultyStatus> RepeatedField`1<EpisodeDifficultyStatus> List<EpisodeDifficultyStatus> Pointer )
            value.Chapter                                   = GetInt32(new IntPtr(p + 0x030)); // 024661040FB0 0x30 Chapter                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
