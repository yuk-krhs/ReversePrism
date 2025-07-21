using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstEpisodeId                             ModelPrimitiveType int int int Int32
    // 014 MstUnitId                                ModelPrimitiveType int int int Int32
    // 018 DifficultyType                           ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 020 IProduceLogCellList                      ModelClassListType List`1<IProduceLogCell> List`1<IProduceLogCell> List<IProduceLogCell> Pointer
    public partial class LogIndexViewModel : DataModel
    {
        public int                                      MstEpisodeId                            { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public ProduceDifficultyType                    DifficultyType                          { get; set; }
        public List<IProduceLogCell>?                   IProduceLogCellList                     { get; set; }

        public static LogIndexViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LogIndexViewModel() { Pointer= p0 };

            value.MstEpisodeId                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstEpisodeId                ( ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.DifficultyType                            = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x018)); // 0x18 DifficultyType              ( ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.IProduceLogCellList                       = GetObjectList<IProduceLogCell>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProduceLogCell.FromPointer); // 0x20 IProduceLogCellList         ( ModelClassListType List`1<IProduceLogCell> List`1<IProduceLogCell> List<IProduceLogCell> Pointer )

            return value;
        }
    }
}
