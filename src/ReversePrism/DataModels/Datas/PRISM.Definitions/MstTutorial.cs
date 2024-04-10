using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TutorialCategory                         0001865F4260 ModelPrimitiveType int int int Int32
    // 014 Phase                                    0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstTutorial : DataModel
    {
        public int                                      TutorialCategory                        { get; set; }
        public int                                      Phase                                   { get; set; }

        public static MstTutorial? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstTutorial() { Pointer= p0 };

            value.TutorialCategory                          = GetInt32(new IntPtr(p + 0x010)); // 0245A461E1A8 0x10 TutorialCategory            ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Phase                                     = GetInt32(new IntPtr(p + 0x014)); // 0245A461E1C8 0x14 Phase                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
