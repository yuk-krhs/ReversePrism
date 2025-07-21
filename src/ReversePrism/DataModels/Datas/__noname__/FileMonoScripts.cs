using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FilePath                                 ModelPrimitiveType string string string String
    // 018 MonoScriptInfos                          ModelEnumListType MonoScriptInfo[] MonoScriptInfo[] List<MonoScriptInfo> Pointer
    public partial class FileMonoScripts : DataModel
    {
        public string                                   FilePath                                { get; set; }
        public List<MonoScriptInfo>?                    MonoScriptInfos                         { get; set; }

        public static FileMonoScripts? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FileMonoScripts() { Pointer= p0 };

            value.FilePath                                  = GetString(new IntPtr(p + 0x010)); // 0x10 FilePath                    ( ModelPrimitiveType string string string String )
            value.MonoScriptInfos                           = GetEnumList<MonoScriptInfo>(new IntPtr(p + 0x018)); // 0x18 MonoScriptInfos             ( ModelEnumListType MonoScriptInfo[] MonoScriptInfo[] List<MonoScriptInfo> Pointer )

            return value;
        }
    }
}
