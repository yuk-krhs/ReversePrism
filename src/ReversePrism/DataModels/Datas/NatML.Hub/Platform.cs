using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Android                                  string IL2CPP_TYPE_STRING
    // 000 iOS                                      string IL2CPP_TYPE_STRING
    // 000 Linux                                    string IL2CPP_TYPE_STRING
    // 000 macOS                                    string IL2CPP_TYPE_STRING
    // 000 Web                                      string IL2CPP_TYPE_STRING
    // 000 Windows                                  string IL2CPP_TYPE_STRING
    public partial class Platform
    {

        public static Platform? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Platform();


            return value;
        }
    }
}
