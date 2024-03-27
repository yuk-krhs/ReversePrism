using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScreenType                               000186540DD0 ModelEnumType ScreenType ScreenType ScreenType Int32
    // 018 Builder                                  SerializableInterface`1<IMobileScreenBuilder> IL2CPP_TYPE_GENERICINST
    public partial class KeyBuilderPair
    {
        public ScreenType                               ScreenType                              { get; set; }

        public static KeyBuilderPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KeyBuilderPair();

            value.ScreenType                                = (ScreenType)GetInt32(new IntPtr(p + 0x010)); // 0270DB11F750 0x10 ScreenType                  ( 000186540DD0 ModelEnumType ScreenType ScreenType ScreenType Int32 )

            return value;
        }
    }
}
