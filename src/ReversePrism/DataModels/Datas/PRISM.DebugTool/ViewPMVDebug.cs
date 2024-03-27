using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 Prm                                      0001866E7680 ModelClassType ViewPMVDebugParameter ViewPMVDebugParameter ViewPMVDebugParameter Pointer
    // 060 PreloadTask                              00018669FD00 ModelEnumType UniTask UniTask UniTask Int32
    // 070 UnitID                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ViewPMVDebug
    {
        public ViewPMVDebugParameter?                   Prm                                     { get; set; }
        public UniTask                                  PreloadTask                             { get; set; }
        public int                                      UnitID                                  { get; set; }

        public static ViewPMVDebug? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewPMVDebug();

            value.Prm                                       = GetObject<ViewPMVDebugParameter>(new IntPtr(p + 0x058), ReversePrism.DataModels.ViewPMVDebugParameter.FromPointer); // 0270D594E0F0 0x58 Prm                         ( 0001866E7680 ModelClassType ViewPMVDebugParameter ViewPMVDebugParameter ViewPMVDebugParameter Pointer )
            value.PreloadTask                               = (UniTask)GetInt32(new IntPtr(p + 0x060)); // 0270D594E110 0x60 PreloadTask                 ( 00018669FD00 ModelEnumType UniTask UniTask UniTask Int32 )
            value.UnitID                                    = GetInt32(new IntPtr(p + 0x070)); // 0270D594E130 0x70 UnitID                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
