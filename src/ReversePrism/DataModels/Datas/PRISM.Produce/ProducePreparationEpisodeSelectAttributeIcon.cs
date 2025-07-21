using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 VodavimeLabel                            ModelClassType VoDaViMeLabel VoDaViMeLabel VoDaViMeLabel Pointer
    public partial class ProducePreparationEpisodeSelectAttributeIcon : DataModel
    {
        public VoDaViMeLabel?                           VodavimeLabel                           { get; set; }

        public static ProducePreparationEpisodeSelectAttributeIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationEpisodeSelectAttributeIcon() { Pointer= p0 };

            value.VodavimeLabel                             = GetObject<VoDaViMeLabel>(new IntPtr(p + 0x020), ReversePrism.DataModels.VoDaViMeLabel.FromPointer); // 0x20 VodavimeLabel               ( ModelClassType VoDaViMeLabel VoDaViMeLabel VoDaViMeLabel Pointer )

            return value;
        }
    }
}
