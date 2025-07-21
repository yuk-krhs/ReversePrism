using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 State                                    ModelPrimitiveType int int int Int32
    // 010 AllElementsRequired                      ModelPrimitiveType int int int Int32
    // 010 CurPosIndex                              ModelPrimitiveType int int int Int32
    // 010 NumberOfRunningPos                       ModelPrimitiveType int int int Int32
    public partial class StateUnion : DataModel
    {
        public int                                      State                                   { get; set; }
        public int                                      AllElementsRequired                     { get; set; }
        public int                                      CurPosIndex                             { get; set; }
        public int                                      NumberOfRunningPos                      { get; set; }

        public static StateUnion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StateUnion() { Pointer= p0 };

            value.State                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 State                       ( ModelPrimitiveType int int int Int32 )
            value.AllElementsRequired                       = GetInt32(new IntPtr(p + 0x010)); // 0x10 AllElementsRequired         ( ModelPrimitiveType int int int Int32 )
            value.CurPosIndex                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 CurPosIndex                 ( ModelPrimitiveType int int int Int32 )
            value.NumberOfRunningPos                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 NumberOfRunningPos          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
