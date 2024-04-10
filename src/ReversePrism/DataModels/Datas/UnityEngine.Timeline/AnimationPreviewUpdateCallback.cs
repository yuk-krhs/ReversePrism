using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Output                                 0001866B67B0 ModelEnumType AnimationPlayableOutput AnimationPlayableOutput AnimationPlayableOutput Int32
    // 020 M_Graph                                  00018663F7C0 ModelEnumType PlayableGraph PlayableGraph PlayableGraph Int32
    // 030 M_PreviewComponents                      000185CE0A78 ModelClassListType List`1<IAnimationWindowPreview> List`1<IAnimationWindowPreview> List<IAnimationWindowPreview> Pointer
    public partial class AnimationPreviewUpdateCallback : DataModel
    {
        public AnimationPlayableOutput                  M_Output                                { get; set; }
        public PlayableGraph                            M_Graph                                 { get; set; }
        public List<IAnimationWindowPreview>?           M_PreviewComponents                     { get; set; }

        public static AnimationPreviewUpdateCallback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimationPreviewUpdateCallback() { Pointer= p0 };

            value.M_Output                                  = (AnimationPlayableOutput)GetInt32(new IntPtr(p + 0x010)); // 02466B299A28 0x10 M_Output                    ( 0001866B67B0 ModelEnumType AnimationPlayableOutput AnimationPlayableOutput AnimationPlayableOutput Int32 )
            value.M_Graph                                   = (PlayableGraph)GetInt32(new IntPtr(p + 0x020)); // 02466B299A48 0x20 M_Graph                     ( 00018663F7C0 ModelEnumType PlayableGraph PlayableGraph PlayableGraph Int32 )
            value.M_PreviewComponents                       = GetObjectList<IAnimationWindowPreview>(new IntPtr(p + 0x030), ReversePrism.DataModels.IAnimationWindowPreview.FromPointer); // 02466B299A68 0x30 M_PreviewComponents         ( 000185CE0A78 ModelClassListType List`1<IAnimationWindowPreview> List`1<IAnimationWindowPreview> List<IAnimationWindowPreview> Pointer )

            return value;
        }
    }
}
