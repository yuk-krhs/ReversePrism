using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Random                                   ModelClassType Random Random Random Pointer
    // 018 MstEpisodeId                             ModelPrimitiveType int int int Int32
    // 020 SettingModel                             ModelClassType ProduceAutoSettingModel ProduceAutoSettingModel ProduceAutoSettingModel Pointer
    public partial class SubSeasonSelectModel : DataModel
    {
        public Random?                                  Random                                  { get; set; }
        public int                                      MstEpisodeId                            { get; set; }
        public ProduceAutoSettingModel?                 SettingModel                            { get; set; }

        public static SubSeasonSelectModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubSeasonSelectModel() { Pointer= p0 };

            value.Random                                    = GetObject<Random>(new IntPtr(p + 0x010), ReversePrism.DataModels.Random.FromPointer); // 0x10 Random                      ( ModelClassType Random Random Random Pointer )
            value.MstEpisodeId                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstEpisodeId                ( ModelPrimitiveType int int int Int32 )
            value.SettingModel                              = GetObject<ProduceAutoSettingModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceAutoSettingModel.FromPointer); // 0x20 SettingModel                ( ModelClassType ProduceAutoSettingModel ProduceAutoSettingModel ProduceAutoSettingModel Pointer )

            return value;
        }
    }
}
