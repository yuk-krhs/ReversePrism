using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentDepth                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 IsActive                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 AxisTree                                 0001866EA170 ModelClassType Asttree Asttree Asttree Pointer
    // 020 AxisStack                                00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    public partial class ActiveAxis
    {
        public int                                      CurrentDepth                            { get; set; }
        public bool                                     IsActive                                { get; set; }
        public Asttree?                                 AxisTree                                { get; set; }
        public ArrayList?                               AxisStack                               { get; set; }

        public static ActiveAxis? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ActiveAxis();

            value.CurrentDepth                              = GetInt32(new IntPtr(p + 0x010)); // 0270D74D53F0 0x10 CurrentDepth                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsActive                                  = GetBool(new IntPtr(p + 0x014)); // 0270D74D5410 0x14 IsActive                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AxisTree                                  = GetObject<Asttree>(new IntPtr(p + 0x018), ReversePrism.DataModels.Asttree.FromPointer); // 0270D74D5430 0x18 AxisTree                    ( 0001866EA170 ModelClassType Asttree Asttree Asttree Pointer )
            value.AxisStack                                 = GetObject<ArrayList>(new IntPtr(p + 0x020), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D74D5450 0x20 AxisStack                   ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )

            return value;
        }
    }
}
