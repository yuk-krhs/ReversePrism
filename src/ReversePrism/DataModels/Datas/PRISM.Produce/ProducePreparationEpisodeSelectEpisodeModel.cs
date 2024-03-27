using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EpisodeStatus                            0001867618B0 ModelClassType IEpisodeStatus IEpisodeStatus IEpisodeStatus Pointer
    // 018 Attribute                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ProducePreparationEpisodeSelectEpisodeModel
    {
        public IEpisodeStatus?                          EpisodeStatus                           { get; set; }
        public int                                      Attribute                               { get; set; }

        public static ProducePreparationEpisodeSelectEpisodeModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationEpisodeSelectEpisodeModel();

            value.EpisodeStatus                             = GetObject<IEpisodeStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IEpisodeStatus.FromPointer); // 0270D59DC2C0 0x10 EpisodeStatus               ( 0001867618B0 ModelClassType IEpisodeStatus IEpisodeStatus IEpisodeStatus Pointer )
            value.Attribute                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D59DC2E0 0x18 Attribute                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
