using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 State                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 010 AllElementsRequired                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 010 CurPosIndex                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 010 NumberOfRunningPos                       0001865F36C0 ModelPrimitiveType int int int Int32
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

            value.State                                     = GetInt32(new IntPtr(p + 0x010)); // 024667558830 0x10 State                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.AllElementsRequired                       = GetInt32(new IntPtr(p + 0x010)); // 024667558850 0x10 AllElementsRequired         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CurPosIndex                               = GetInt32(new IntPtr(p + 0x010)); // 024667558870 0x10 CurPosIndex                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NumberOfRunningPos                        = GetInt32(new IntPtr(p + 0x010)); // 024667558890 0x10 NumberOfRunningPos          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
