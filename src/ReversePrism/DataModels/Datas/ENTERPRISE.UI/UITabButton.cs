using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 1B0 ImageStateList                           000185CC4C18 ModelClassListType ImageInfo[] ImageInfo[] List<ImageInfo> Pointer
    // 1B8 TextStateList                            000185CC4D28 ModelClassListType TextInfo[] TextInfo[] List<TextInfo> Pointer
    // 1C0 TabEnabled                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1C4 CurrentState                             000186669DF0 ModelEnumType TabState TabState TabState Int32
    // 1C8 Param                                    000186671910 ModelPrimitiveType string string string String
    // 1D0 ImagePictogramList                       000185CC4C18 ModelClassListType ImageInfo[] ImageInfo[] List<ImageInfo> Pointer
    public partial class UITabButton
    {
        public List<ImageInfo>?                         ImageStateList                          { get; set; }
        public List<TextInfo>?                          TextStateList                           { get; set; }
        public bool                                     TabEnabled                              { get; set; }
        public TabState                                 CurrentState                            { get; set; }
        public string                                   Param                                   { get; set; }
        public List<ImageInfo>?                         ImagePictogramList                      { get; set; }

        public static UITabButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UITabButton();

            value.ImageStateList                            = GetObjectList<ImageInfo>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.ImageInfo.FromPointer); // 0270D4BCCDC0 0x1B0 ImageStateList              ( 000185CC4C18 ModelClassListType ImageInfo[] ImageInfo[] List<ImageInfo> Pointer )
            value.TextStateList                             = GetObjectList<TextInfo>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.TextInfo.FromPointer); // 0270D4BCCDE0 0x1B8 TextStateList               ( 000185CC4D28 ModelClassListType TextInfo[] TextInfo[] List<TextInfo> Pointer )
            value.TabEnabled                                = GetBool(new IntPtr(p + 0x1C0)); // 0270D4BCCE00 0x1C0 TabEnabled                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CurrentState                              = (TabState)GetInt32(new IntPtr(p + 0x1C4)); // 0270D4BCCE20 0x1C4 CurrentState                ( 000186669DF0 ModelEnumType TabState TabState TabState Int32 )
            value.Param                                     = GetString(new IntPtr(p + 0x1C8)); // 0270D4BCCE40 0x1C8 Param                       ( 000186671910 ModelPrimitiveType string string string String )
            value.ImagePictogramList                        = GetObjectList<ImageInfo>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.ImageInfo.FromPointer); // 0270D4BCCE60 0x1D0 ImagePictogramList          ( 000185CC4C18 ModelClassListType ImageInfo[] ImageInfo[] List<ImageInfo> Pointer )

            return value;
        }
    }
}
