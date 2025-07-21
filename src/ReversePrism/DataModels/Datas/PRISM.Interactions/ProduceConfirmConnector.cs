using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 EpisodeSelectModel                       ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer
    // 090 AutoReleasedConfigRef                    ModelPrimitiveType string string string String
    // 098 InheritanceReleasedConfigRef             ModelPrimitiveType string string string String
    public partial class ProduceConfirmConnector : DataModel
    {
        public ViewProducePreparationEpisodeSelectModel? EpisodeSelectModel                      { get; set; }
        public string                                   AutoReleasedConfigRef                   { get; set; }
        public string                                   InheritanceReleasedConfigRef            { get; set; }

        public static ProduceConfirmConnector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceConfirmConnector() { Pointer= p0 };

            value.EpisodeSelectModel                        = GetObject<ViewProducePreparationEpisodeSelectModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.ViewProducePreparationEpisodeSelectModel.FromPointer); // 0x88 EpisodeSelectModel          ( ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer )
            value.AutoReleasedConfigRef                     = GetString(new IntPtr(p + 0x090)); // 0x90 AutoReleasedConfigRef       ( ModelPrimitiveType string string string String )
            value.InheritanceReleasedConfigRef              = GetString(new IntPtr(p + 0x098)); // 0x98 InheritanceReleasedConfigRef ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
