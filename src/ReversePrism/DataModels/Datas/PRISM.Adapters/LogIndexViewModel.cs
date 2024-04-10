using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstEpisodeId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 DifficultyType                           00018660BEF0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 020 IProduceLogCellList                      000185CE7828 ModelClassListType List`1<IProduceLogCell> List`1<IProduceLogCell> List<IProduceLogCell> Pointer
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

            value.MstEpisodeId                              = GetInt32(new IntPtr(p + 0x010)); // 024665FAE590 0x10 MstEpisodeId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x014)); // 024665FAE5B0 0x14 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DifficultyType                            = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x018)); // 024665FAE5D0 0x18 DifficultyType              ( 00018660BEF0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.IProduceLogCellList                       = GetObjectList<IProduceLogCell>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProduceLogCell.FromPointer); // 024665FAE5F0 0x20 IProduceLogCellList         ( 000185CE7828 ModelClassListType List`1<IProduceLogCell> List`1<IProduceLogCell> List<IProduceLogCell> Pointer )

            return value;
        }
    }
}
