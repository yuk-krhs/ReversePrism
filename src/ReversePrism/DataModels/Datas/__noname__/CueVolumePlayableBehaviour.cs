using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Volume                                   ModelPrimitiveType float float float Single
    // 018 CueName                                  ModelPrimitiveType string string string String
    // 020 BackUpVolume                             ModelPrimitiveType float float float Single
    public partial class CueVolumePlayableBehaviour : DataModel
    {
        public float                                    Volume                                  { get; set; }
        public string                                   CueName                                 { get; set; }
        public float                                    BackUpVolume                            { get; set; }

        public static CueVolumePlayableBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CueVolumePlayableBehaviour() { Pointer= p0 };

            value.Volume                                    = GetSingle(new IntPtr(p + 0x010)); // 0x10 Volume                      ( ModelPrimitiveType float float float Single )
            value.CueName                                   = GetString(new IntPtr(p + 0x018)); // 0x18 CueName                     ( ModelPrimitiveType string string string String )
            value.BackUpVolume                              = GetSingle(new IntPtr(p + 0x020)); // 0x20 BackUpVolume                ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
