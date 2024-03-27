using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Settings                                 000185CFA938 ModelClassListType List`1<PostProcessEffectSettings> List`1<PostProcessEffectSettings> List<PostProcessEffectSettings> Pointer
    // 020 IsDirty                                  000186597BE0 ModelPrimitiveType bool bool bool Bool
    public partial class PostProcessProfile
    {
        public List<PostProcessEffectSettings>?         Settings                                { get; set; }
        public bool                                     IsDirty                                 { get; set; }

        public static PostProcessProfile? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PostProcessProfile();

            value.Settings                                  = GetObjectList<PostProcessEffectSettings>(new IntPtr(p + 0x018), ReversePrism.DataModels.PostProcessEffectSettings.FromPointer); // 027006125BA0 0x18 Settings                    ( 000185CFA938 ModelClassListType List`1<PostProcessEffectSettings> List`1<PostProcessEffectSettings> List<PostProcessEffectSettings> Pointer )
            value.IsDirty                                   = GetBool(new IntPtr(p + 0x020)); // 027006125BC0 0x20 IsDirty                     ( 000186597BE0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
