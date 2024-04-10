using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_sinks                                  Hashtable IL2CPP_TYPE_CLASS
    // 008 processMessageMethod                     MethodInfo IL2CPP_TYPE_CLASS
    // 010 DomainID                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class CrossAppDomainSink : DataModel
    {
        public int                                      DomainID                                { get; set; }

        public static CrossAppDomainSink? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CrossAppDomainSink() { Pointer= p0 };

            value.DomainID                                  = GetInt32(new IntPtr(p + 0x010)); // 024666C5D648 0x10 DomainID                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
