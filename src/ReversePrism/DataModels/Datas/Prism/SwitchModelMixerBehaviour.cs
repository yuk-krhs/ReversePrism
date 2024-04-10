using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 LastUnitID                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SwitchModelMixerBehaviour : DataModel
    {
        public int                                      LastUnitID                              { get; set; }

        public static SwitchModelMixerBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchModelMixerBehaviour() { Pointer= p0 };

            value.LastUnitID                                = GetInt32(new IntPtr(p + 0x038)); // 024664E72E10 0x38 LastUnitID                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
