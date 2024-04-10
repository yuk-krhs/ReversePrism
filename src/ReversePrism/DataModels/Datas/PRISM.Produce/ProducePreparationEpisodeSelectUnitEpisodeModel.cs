using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 EpisodeModels                            000185B9D540 ModelClassListType ProducePreparationEpisodeSelectEpisodeModel[] ProducePreparationEpisodeSelectEpisodeModel[] List<ProducePreparationEpisodeSelectEpisodeModel> Pointer
    public partial class ProducePreparationEpisodeSelectUnitEpisodeModel : DataModel
    {
        public int                                      UnitId                                  { get; set; }
        public List<ProducePreparationEpisodeSelectEpisodeModel>? EpisodeModels                           { get; set; }

        public static ProducePreparationEpisodeSelectUnitEpisodeModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationEpisodeSelectUnitEpisodeModel() { Pointer= p0 };

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x010)); // 024665A51BC8 0x10 UnitId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EpisodeModels                             = GetObjectList<ProducePreparationEpisodeSelectEpisodeModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProducePreparationEpisodeSelectEpisodeModel.FromPointer); // 024665A51BE8 0x18 EpisodeModels               ( 000185B9D540 ModelClassListType ProducePreparationEpisodeSelectEpisodeModel[] ProducePreparationEpisodeSelectEpisodeModel[] List<ProducePreparationEpisodeSelectEpisodeModel> Pointer )

            return value;
        }
    }
}
