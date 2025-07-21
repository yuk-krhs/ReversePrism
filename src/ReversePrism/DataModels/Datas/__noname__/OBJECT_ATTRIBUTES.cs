using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Length                                   ModelPrimitiveType uint uint uint UInt32
    // 018 RootDirectory                            <int> IL2CPP_TYPE_I
    // 020 ObjectName                               IntPtr IL2CPP_TYPE_PTR
    // 028 Attributes                               ModelEnumType ObjectAttributes ObjectAttributes ObjectAttributes Int32
    // 030 SecurityDescriptor                       IntPtr IL2CPP_TYPE_PTR
    // 038 SecurityQualityOfService                 IntPtr IL2CPP_TYPE_PTR
    public partial class OBJECT_ATTRIBUTES : DataModel
    {
        public uint                                     Length                                  { get; set; }
        public ObjectAttributes                         Attributes                              { get; set; }

        public static OBJECT_ATTRIBUTES? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OBJECT_ATTRIBUTES() { Pointer= p0 };

            value.Length                                    = GetUInt32(new IntPtr(p + 0x010)); // 0x10 Length                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.Attributes                                = (ObjectAttributes)GetInt32(new IntPtr(p + 0x028)); // 0x28 Attributes                  ( ModelEnumType ObjectAttributes ObjectAttributes ObjectAttributes Int32 )

            return value;
        }
    }
}
