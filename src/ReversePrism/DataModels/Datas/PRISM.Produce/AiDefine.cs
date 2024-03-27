using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 EditorAiPatternScriptableObjectPath      string IL2CPP_TYPE_STRING
    // 000 AiPatternScriptableObjectPath            string IL2CPP_TYPE_STRING
    // 000 EditorAiExcelPath                        string IL2CPP_TYPE_STRING
    public partial class AiDefine
    {

        public static AiDefine? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AiDefine();


            return value;
        }
    }
}
