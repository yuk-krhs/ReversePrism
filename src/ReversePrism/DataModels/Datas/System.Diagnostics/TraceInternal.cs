using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 appName                                  string IL2CPP_TYPE_STRING
    // 008 listeners                                TraceListenerCollection IL2CPP_TYPE_CLASS
    // 010 AutoFlush                                ModelPrimitiveType bool bool bool Bool
    // 011 UseGlobalLock                            ModelPrimitiveType bool bool bool Bool
    // FFFFFFFF indentLevel                              int IL2CPP_TYPE_I4
    // 014 IndentSize                               ModelPrimitiveType int int int Int32
    // 018 critSec                                  <object> IL2CPP_TYPE_OBJECT
    public partial class TraceInternal : DataModel
    {
        public bool                                     AutoFlush                               { get; set; }
        public bool                                     UseGlobalLock                           { get; set; }
        public int                                      IndentSize                              { get; set; }

        public static TraceInternal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TraceInternal() { Pointer= p0 };

            value.AutoFlush                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 AutoFlush                   ( ModelPrimitiveType bool bool bool Bool )
            value.UseGlobalLock                             = GetBool(new IntPtr(p + 0x011)); // 0x11 UseGlobalLock               ( ModelPrimitiveType bool bool bool Bool )
            value.IndentSize                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 IndentSize                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
