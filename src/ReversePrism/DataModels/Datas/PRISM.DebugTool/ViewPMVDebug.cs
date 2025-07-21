using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Prm                                      ModelClassType ViewPMVDebugParameter ViewPMVDebugParameter ViewPMVDebugParameter Pointer
    // 058 PreloadTask                              ModelEnumType UniTask UniTask UniTask Int32
    // 068 UnitID                                   ModelPrimitiveType int int int Int32
    public partial class ViewPMVDebug : DataModel
    {
        public ViewPMVDebugParameter?                   Prm                                     { get; set; }
        public UniTask                                  PreloadTask                             { get; set; }
        public int                                      UnitID                                  { get; set; }

        public static ViewPMVDebug? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewPMVDebug() { Pointer= p0 };

            value.Prm                                       = GetObject<ViewPMVDebugParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.ViewPMVDebugParameter.FromPointer); // 0x50 Prm                         ( ModelClassType ViewPMVDebugParameter ViewPMVDebugParameter ViewPMVDebugParameter Pointer )
            value.PreloadTask                               = (UniTask)GetInt32(new IntPtr(p + 0x058)); // 0x58 PreloadTask                 ( ModelEnumType UniTask UniTask UniTask Int32 )
            value.UnitID                                    = GetInt32(new IntPtr(p + 0x068)); // 0x68 UnitID                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
