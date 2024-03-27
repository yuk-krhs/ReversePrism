using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SelectedEpisodeStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEpisodeIdFieldNumber                  int IL2CPP_TYPE_I4
    // 018 MstEpisodeId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 01C MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DifficultyTypeFieldNumber                int IL2CPP_TYPE_I4
    // 020 DifficultyType                           00018653B4F0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 000 ChapterFieldNumber                       int IL2CPP_TYPE_I4
    // 024 Chapter                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SelectedEpisodeStatus
    {
        public int                                      MstEpisodeId                            { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public ProduceDifficultyType                    DifficultyType                          { get; set; }
        public int                                      Chapter                                 { get; set; }

        public static SelectedEpisodeStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectedEpisodeStatus();

            value.MstEpisodeId                              = GetInt32(new IntPtr(p + 0x018)); // 0270041D7D90 0x18 MstEpisodeId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x01C)); // 0270041D7DD0 0x1C MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DifficultyType                            = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x020)); // 0270041D7E10 0x20 DifficultyType              ( 00018653B4F0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.Chapter                                   = GetInt32(new IntPtr(p + 0x024)); // 0270041D7E50 0x24 Chapter                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
