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
    // 018 MstEpisodeId                             ModelPrimitiveType int int int Int32
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 01C MstUnitId                                ModelPrimitiveType int int int Int32
    // 000 DifficultyTypeFieldNumber                int IL2CPP_TYPE_I4
    // 020 DifficultyType                           ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 000 ChapterFieldNumber                       int IL2CPP_TYPE_I4
    // 024 Chapter                                  ModelPrimitiveType int int int Int32
    public partial class SelectedEpisodeStatus : DataModel
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
            var value   = new SelectedEpisodeStatus() { Pointer= p0 };

            value.MstEpisodeId                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstEpisodeId                ( ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.DifficultyType                            = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x020)); // 0x20 DifficultyType              ( ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.Chapter                                   = GetInt32(new IntPtr(p + 0x024)); // 0x24 Chapter                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
