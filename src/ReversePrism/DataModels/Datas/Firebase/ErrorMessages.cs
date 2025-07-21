using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DEPENDENCY_NOT_FOUND_ERROR_ANDROID       string IL2CPP_TYPE_STRING
    // 008 DEPENDENCY_NOT_FOUND_ERROR_IOS           string IL2CPP_TYPE_STRING
    // 010 DEPENDENCY_NOT_FOUND_ERROR_GENERIC       ModelPrimitiveType string string string String
    // 018 DLL_NOT_FOUND_ERROR_ANDROID              ModelPrimitiveType string string string String
    // 020 DLL_NOT_FOUND_ERROR_IOS                  ModelPrimitiveType string string string String
    // 028 DLL_NOT_FOUND_ERROR_GENERIC              ModelPrimitiveType string string string String
    public partial class ErrorMessages : DataModel
    {
        public string                                   DEPENDENCY_NOT_FOUND_ERROR_GENERIC      { get; set; }
        public string                                   DLL_NOT_FOUND_ERROR_ANDROID             { get; set; }
        public string                                   DLL_NOT_FOUND_ERROR_IOS                 { get; set; }
        public string                                   DLL_NOT_FOUND_ERROR_GENERIC             { get; set; }

        public static ErrorMessages? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ErrorMessages() { Pointer= p0 };

            value.DEPENDENCY_NOT_FOUND_ERROR_GENERIC        = GetString(new IntPtr(p + 0x010)); // 0x10 DEPENDENCY_NOT_FOUND_ERROR_GENERIC ( ModelPrimitiveType string string string String )
            value.DLL_NOT_FOUND_ERROR_ANDROID               = GetString(new IntPtr(p + 0x018)); // 0x18 DLL_NOT_FOUND_ERROR_ANDROID ( ModelPrimitiveType string string string String )
            value.DLL_NOT_FOUND_ERROR_IOS                   = GetString(new IntPtr(p + 0x020)); // 0x20 DLL_NOT_FOUND_ERROR_IOS     ( ModelPrimitiveType string string string String )
            value.DLL_NOT_FOUND_ERROR_GENERIC               = GetString(new IntPtr(p + 0x028)); // 0x28 DLL_NOT_FOUND_ERROR_GENERIC ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
