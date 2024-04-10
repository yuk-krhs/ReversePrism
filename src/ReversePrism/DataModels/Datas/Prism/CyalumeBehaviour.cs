using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AnimationId                              0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class CyalumeBehaviour : DataModel
    {
        public int                                      AnimationId                             { get; set; }

        public static CyalumeBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CyalumeBehaviour() { Pointer= p0 };

            value.AnimationId                               = GetInt32(new IntPtr(p + 0x010)); // 024664E73C68 0x10 AnimationId                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
