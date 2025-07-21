using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PrefabPath                               string IL2CPP_TYPE_STRING
    // 070 IsLoadingIdol                            ModelPrimitiveType bool bool bool Bool
    // 071 IsSD                                     ModelPrimitiveType bool bool bool Bool
    // 078 UnitIdol                                 ModelClassType UnitIdol UnitIdol UnitIdol Pointer
    // 080 receivedData                             Queue`1<ReceivedData> IL2CPP_TYPE_GENERICINST
    // 088 IsViewPaused                             ModelPrimitiveType bool bool bool Bool
    public partial class AvatarView : DataModel
    {
        public bool                                     IsLoadingIdol                           { get; set; }
        public bool                                     IsSD                                    { get; set; }
        public UnitIdol?                                UnitIdol                                { get; set; }
        public bool                                     IsViewPaused                            { get; set; }

        public static AvatarView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AvatarView() { Pointer= p0 };

            value.IsLoadingIdol                             = GetBool(new IntPtr(p + 0x070)); // 0x70 IsLoadingIdol               ( ModelPrimitiveType bool bool bool Bool )
            value.IsSD                                      = GetBool(new IntPtr(p + 0x071)); // 0x71 IsSD                        ( ModelPrimitiveType bool bool bool Bool )
            value.UnitIdol                                  = GetObject<UnitIdol>(new IntPtr(p + 0x078), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x78 UnitIdol                    ( ModelClassType UnitIdol UnitIdol UnitIdol Pointer )
            value.IsViewPaused                              = GetBool(new IntPtr(p + 0x088)); // 0x88 IsViewPaused                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
