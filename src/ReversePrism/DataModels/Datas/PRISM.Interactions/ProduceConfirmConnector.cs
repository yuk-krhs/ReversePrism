using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 EpisodeSelectModel                       00018651FD70 ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer
    // 098 AutoReleasedConfigRef                    000186671E00 ModelPrimitiveType string string string String
    // 0A0 InheritanceReleasedConfigRef             000186671E00 ModelPrimitiveType string string string String
    public partial class ProduceConfirmConnector
    {
        public ViewProducePreparationEpisodeSelectModel? EpisodeSelectModel                      { get; set; }
        public string                                   AutoReleasedConfigRef                   { get; set; }
        public string                                   InheritanceReleasedConfigRef            { get; set; }

        public static ProduceConfirmConnector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceConfirmConnector();

            value.EpisodeSelectModel                        = GetObject<ViewProducePreparationEpisodeSelectModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.ViewProducePreparationEpisodeSelectModel.FromPointer); // 0270DA132488 0x90 EpisodeSelectModel          ( 00018651FD70 ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer )
            value.AutoReleasedConfigRef                     = GetString(new IntPtr(p + 0x098)); // 0270DA1324A8 0x98 AutoReleasedConfigRef       ( 000186671E00 ModelPrimitiveType string string string String )
            value.InheritanceReleasedConfigRef              = GetString(new IntPtr(p + 0x0A0)); // 0270DA1324C8 0xA0 InheritanceReleasedConfigRef ( 000186671E00 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
