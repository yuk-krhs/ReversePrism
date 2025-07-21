using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enabled                                  ModelPrimitiveType bool bool bool Bool
    // 018 BuildId                                  ModelPrimitiveType string string string String
    // 020 PreBuildScriptableObject                 ModelClassType PreBuildScriptableObject PreBuildScriptableObject PreBuildScriptableObject Pointer
    // 028 UniquePreBuildData                       ModelClassType UniquePreBuildData UniquePreBuildData UniquePreBuildData Pointer
    public partial class PreBuildSerializeData : DataModel
    {
        public bool                                     Enabled                                 { get; set; }
        public string                                   BuildId                                 { get; set; }
        public PreBuildScriptableObject?                PreBuildScriptableObject                { get; set; }
        public UniquePreBuildData?                      UniquePreBuildData                      { get; set; }

        public static PreBuildSerializeData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PreBuildSerializeData() { Pointer= p0 };

            value.Enabled                                   = GetBool(new IntPtr(p + 0x010)); // 0x10 Enabled                     ( ModelPrimitiveType bool bool bool Bool )
            value.BuildId                                   = GetString(new IntPtr(p + 0x018)); // 0x18 BuildId                     ( ModelPrimitiveType string string string String )
            value.PreBuildScriptableObject                  = GetObject<PreBuildScriptableObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.PreBuildScriptableObject.FromPointer); // 0x20 PreBuildScriptableObject    ( ModelClassType PreBuildScriptableObject PreBuildScriptableObject PreBuildScriptableObject Pointer )
            value.UniquePreBuildData                        = GetObject<UniquePreBuildData>(new IntPtr(p + 0x028), ReversePrism.DataModels.UniquePreBuildData.FromPointer); // 0x28 UniquePreBuildData          ( ModelClassType UniquePreBuildData UniquePreBuildData UniquePreBuildData Pointer )

            return value;
        }
    }
}
