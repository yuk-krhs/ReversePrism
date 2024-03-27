using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VocalCounter                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 DanceCounter                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 VisualCounter                            0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class UseTypeCounter
    {
        public int                                      VocalCounter                            { get; set; }
        public int                                      DanceCounter                            { get; set; }
        public int                                      VisualCounter                           { get; set; }

        public static UseTypeCounter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UseTypeCounter();

            value.VocalCounter                              = GetInt32(new IntPtr(p + 0x010)); // 0270D5B7A3B8 0x10 VocalCounter                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DanceCounter                              = GetInt32(new IntPtr(p + 0x014)); // 0270D5B7A3D8 0x14 DanceCounter                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VisualCounter                             = GetInt32(new IntPtr(p + 0x018)); // 0270D5B7A3F8 0x18 VisualCounter               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
