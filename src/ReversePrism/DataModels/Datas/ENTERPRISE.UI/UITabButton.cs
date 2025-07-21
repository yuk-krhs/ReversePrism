using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 1B0 ImageStateList                           ModelClassListType ImageInfo[] ImageInfo[] List<ImageInfo> Pointer
    // 1B8 TextStateList                            ModelClassListType TextInfo[] TextInfo[] List<TextInfo> Pointer
    // 1C0 TabEnabled                               ModelPrimitiveType bool bool bool Bool
    // 1C4 CurrentState                             ModelEnumType TabState TabState TabState Int32
    // 1C8 Param                                    ModelPrimitiveType string string string String
    // 1D0 ImagePictogramList                       ModelClassListType ImageInfo[] ImageInfo[] List<ImageInfo> Pointer
    public partial class UITabButton : DataModel
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
            var value   = new UITabButton() { Pointer= p0 };

            value.ImageStateList                            = GetObjectList<ImageInfo>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.ImageInfo.FromPointer); // 0x1B0 ImageStateList              ( ModelClassListType ImageInfo[] ImageInfo[] List<ImageInfo> Pointer )
            value.TextStateList                             = GetObjectList<TextInfo>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.TextInfo.FromPointer); // 0x1B8 TextStateList               ( ModelClassListType TextInfo[] TextInfo[] List<TextInfo> Pointer )
            value.TabEnabled                                = GetBool(new IntPtr(p + 0x1C0)); // 0x1C0 TabEnabled                  ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentState                              = (TabState)GetInt32(new IntPtr(p + 0x1C4)); // 0x1C4 CurrentState                ( ModelEnumType TabState TabState TabState Int32 )
            value.Param                                     = GetString(new IntPtr(p + 0x1C8)); // 0x1C8 Param                       ( ModelPrimitiveType string string string String )
            value.ImagePictogramList                        = GetObjectList<ImageInfo>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.ImageInfo.FromPointer); // 0x1D0 ImagePictogramList          ( ModelClassListType ImageInfo[] ImageInfo[] List<ImageInfo> Pointer )

            return value;
        }
    }
}
