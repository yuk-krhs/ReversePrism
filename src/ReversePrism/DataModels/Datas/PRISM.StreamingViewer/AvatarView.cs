using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PrefabPath                               string IL2CPP_TYPE_STRING
    // 070 IsSD                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 078 UnitIdol                                 00018670C980 ModelClassType UnitIdol UnitIdol UnitIdol Pointer
    // 080 receivedData                             Queue`1<ReceivedData> IL2CPP_TYPE_GENERICINST
    // 088 IsViewPaused                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class AvatarView : DataModel
    {
        public bool                                     IsSD                                    { get; set; }
        public UnitIdol?                                UnitIdol                                { get; set; }
        public bool                                     IsViewPaused                            { get; set; }

        public static AvatarView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AvatarView() { Pointer= p0 };

            value.IsSD                                      = GetBool(new IntPtr(p + 0x070)); // 024664FA8D68 0x70 IsSD                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UnitIdol                                  = GetObject<UnitIdol>(new IntPtr(p + 0x078), ReversePrism.DataModels.UnitIdol.FromPointer); // 024664FA8D88 0x78 UnitIdol                    ( 00018670C980 ModelClassType UnitIdol UnitIdol UnitIdol Pointer )
            value.IsViewPaused                              = GetBool(new IntPtr(p + 0x088)); // 024664FA8DC8 0x88 IsViewPaused                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
