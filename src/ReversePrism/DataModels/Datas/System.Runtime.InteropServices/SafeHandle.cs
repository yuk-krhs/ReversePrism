using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 handle                                   <int> IL2CPP_TYPE_I
    // 018 State                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C OwnsHandle                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01D FullyInitialized                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 RefCount_Mask                            int IL2CPP_TYPE_I4
    // 000 RefCount_One                             int IL2CPP_TYPE_I4
    public partial class SafeHandle
    {
        public int                                      State                                   { get; set; }
        public bool                                     OwnsHandle                              { get; set; }
        public bool                                     FullyInitialized                        { get; set; }

        public static SafeHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SafeHandle();

            value.State                                     = GetInt32(new IntPtr(p + 0x018)); // 027003D00A80 0x18 State                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OwnsHandle                                = GetBool(new IntPtr(p + 0x01C)); // 027003D00AA0 0x1C OwnsHandle                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FullyInitialized                          = GetBool(new IntPtr(p + 0x01D)); // 027003D00AC0 0x1D FullyInitialized            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
