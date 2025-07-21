using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FavoriteToggle                           ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 028 Particle                                 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    // 030 onClickSubject                           Subject`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class TwestaFavoriteToggle : DataModel
    {
        public ToggleButton?                            FavoriteToggle                          { get; set; }
        public ParticleSystem?                          Particle                                { get; set; }

        public static TwestaFavoriteToggle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaFavoriteToggle() { Pointer= p0 };

            value.FavoriteToggle                            = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x20 FavoriteToggle              ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.Particle                                  = GetObject<ParticleSystem>(new IntPtr(p + 0x028), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0x28 Particle                    ( ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )

            return value;
        }
    }
}
