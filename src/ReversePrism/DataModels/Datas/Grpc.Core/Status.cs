using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultSuccess                           Status IL2CPP_TYPE_VALUETYPE
    // 018 DefaultCancelled                         ModelEnumType Status Status Status Int32
    // 010 StatusCode                               ModelEnumType StatusCode StatusCode StatusCode Int32
    // 018 Detail                                   ModelPrimitiveType string string string String
    // 020 DebugException                           ModelClassType Exception Exception Exception Pointer
    public partial class Status : DataModel
    {
        public Status                                   DefaultCancelled                        { get; set; }
        public StatusCode                               StatusCode                              { get; set; }
        public string                                   Detail                                  { get; set; }
        public Exception?                               DebugException                          { get; set; }

        public static Status? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Status() { Pointer= p0 };

            value.DefaultCancelled                          = (Status)GetInt32(new IntPtr(p + 0x018)); // 0x18 DefaultCancelled            ( ModelEnumType Status Status Status Int32 )
            value.StatusCode                                = (StatusCode)GetInt32(new IntPtr(p + 0x010)); // 0x10 StatusCode                  ( ModelEnumType StatusCode StatusCode StatusCode Int32 )
            value.Detail                                    = GetString(new IntPtr(p + 0x018)); // 0x18 Detail                      ( ModelPrimitiveType string string string String )
            value.DebugException                            = GetObject<Exception>(new IntPtr(p + 0x020), ReversePrism.DataModels.Exception.FromPointer); // 0x20 DebugException              ( ModelClassType Exception Exception Exception Pointer )

            return value;
        }
    }
}
