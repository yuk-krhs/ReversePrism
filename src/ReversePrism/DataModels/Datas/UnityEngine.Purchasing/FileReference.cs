using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_FilePath                               ModelPrimitiveType string string string String
    // 018 M_Logger                                 ModelClassType ILogger ILogger ILogger Pointer
    public partial class FileReference : DataModel
    {
        public string                                   M_FilePath                              { get; set; }
        public ILogger?                                 M_Logger                                { get; set; }

        public static FileReference? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FileReference() { Pointer= p0 };

            value.M_FilePath                                = GetString(new IntPtr(p + 0x010)); // 0x10 M_FilePath                  ( ModelPrimitiveType string string string String )
            value.M_Logger                                  = GetObject<ILogger>(new IntPtr(p + 0x018), ReversePrism.DataModels.ILogger.FromPointer); // 0x18 M_Logger                    ( ModelClassType ILogger ILogger ILogger Pointer )

            return value;
        }
    }
}
