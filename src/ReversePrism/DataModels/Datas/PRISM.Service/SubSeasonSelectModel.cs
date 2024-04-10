using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Random                                   0001866093D0 ModelClassType Random Random Random Pointer
    // 018 SettingModel                             000186530A50 ModelClassType ProduceAutoSettingModel ProduceAutoSettingModel ProduceAutoSettingModel Pointer
    public partial class SubSeasonSelectModel : DataModel
    {
        public Random?                                  Random                                  { get; set; }
        public ProduceAutoSettingModel?                 SettingModel                            { get; set; }

        public static SubSeasonSelectModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubSeasonSelectModel() { Pointer= p0 };

            value.Random                                    = GetObject<Random>(new IntPtr(p + 0x010), ReversePrism.DataModels.Random.FromPointer); // 0246664C8B90 0x10 Random                      ( 0001866093D0 ModelClassType Random Random Random Pointer )
            value.SettingModel                              = GetObject<ProduceAutoSettingModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceAutoSettingModel.FromPointer); // 0246664C8BB0 0x18 SettingModel                ( 000186530A50 ModelClassType ProduceAutoSettingModel ProduceAutoSettingModel ProduceAutoSettingModel Pointer )

            return value;
        }
    }
}
