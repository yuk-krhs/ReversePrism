using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_StoryboardGlobalMute                   bool IL2CPP_TYPE_BOOLEAN
    // 030 M_ShowImage                              ModelPrimitiveType bool bool bool Bool
    // 038 M_Image                                  ModelClassType Texture Texture Texture Pointer
    // 040 M_Aspect                                 ModelEnumType FillStrategy FillStrategy FillStrategy Int32
    // 044 M_Alpha                                  ModelPrimitiveType float float float Single
    // 048 M_Center                                 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 050 M_Rotation                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 05C M_Scale                                  ModelEnumType Vector2 Vector2 Vector2 Int32
    // 064 M_SyncScale                              ModelPrimitiveType bool bool bool Bool
    // 065 M_MuteCamera                             ModelPrimitiveType bool bool bool Bool
    // 068 M_SplitView                              ModelPrimitiveType float float float Single
    // 06C M_RenderMode                             ModelEnumType StoryboardRenderMode StoryboardRenderMode StoryboardRenderMode Int32
    // 070 M_SortingOrder                           ModelPrimitiveType int int int Int32
    // 074 M_PlaneDistance                          ModelPrimitiveType float float float Single
    // 078 MCanvasInfo                              ModelClassListType List`1<CanvasInfo> List`1<CanvasInfo> List<CanvasInfo> Pointer
    public partial class CinemachineStoryboard : DataModel
    {
        public bool                                     M_ShowImage                             { get; set; }
        public Texture?                                 M_Image                                 { get; set; }
        public FillStrategy                             M_Aspect                                { get; set; }
        public float                                    M_Alpha                                 { get; set; }
        public Vector2                                  M_Center                                { get; set; }
        public Vector3                                  M_Rotation                              { get; set; }
        public Vector2                                  M_Scale                                 { get; set; }
        public bool                                     M_SyncScale                             { get; set; }
        public bool                                     M_MuteCamera                            { get; set; }
        public float                                    M_SplitView                             { get; set; }
        public StoryboardRenderMode                     M_RenderMode                            { get; set; }
        public int                                      M_SortingOrder                          { get; set; }
        public float                                    M_PlaneDistance                         { get; set; }
        public List<CanvasInfo>?                        MCanvasInfo                             { get; set; }

        public static CinemachineStoryboard? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineStoryboard() { Pointer= p0 };

            value.M_ShowImage                               = GetBool(new IntPtr(p + 0x030)); // 0x30 M_ShowImage                 ( ModelPrimitiveType bool bool bool Bool )
            value.M_Image                                   = GetObject<Texture>(new IntPtr(p + 0x038), ReversePrism.DataModels.Texture.FromPointer); // 0x38 M_Image                     ( ModelClassType Texture Texture Texture Pointer )
            value.M_Aspect                                  = (FillStrategy)GetInt32(new IntPtr(p + 0x040)); // 0x40 M_Aspect                    ( ModelEnumType FillStrategy FillStrategy FillStrategy Int32 )
            value.M_Alpha                                   = GetSingle(new IntPtr(p + 0x044)); // 0x44 M_Alpha                     ( ModelPrimitiveType float float float Single )
            value.M_Center                                  = (Vector2)GetInt32(new IntPtr(p + 0x048)); // 0x48 M_Center                    ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Rotation                                = (Vector3)GetInt32(new IntPtr(p + 0x050)); // 0x50 M_Rotation                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Scale                                   = (Vector2)GetInt32(new IntPtr(p + 0x05C)); // 0x5C M_Scale                     ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_SyncScale                               = GetBool(new IntPtr(p + 0x064)); // 0x64 M_SyncScale                 ( ModelPrimitiveType bool bool bool Bool )
            value.M_MuteCamera                              = GetBool(new IntPtr(p + 0x065)); // 0x65 M_MuteCamera                ( ModelPrimitiveType bool bool bool Bool )
            value.M_SplitView                               = GetSingle(new IntPtr(p + 0x068)); // 0x68 M_SplitView                 ( ModelPrimitiveType float float float Single )
            value.M_RenderMode                              = (StoryboardRenderMode)GetInt32(new IntPtr(p + 0x06C)); // 0x6C M_RenderMode                ( ModelEnumType StoryboardRenderMode StoryboardRenderMode StoryboardRenderMode Int32 )
            value.M_SortingOrder                            = GetInt32(new IntPtr(p + 0x070)); // 0x70 M_SortingOrder              ( ModelPrimitiveType int int int Int32 )
            value.M_PlaneDistance                           = GetSingle(new IntPtr(p + 0x074)); // 0x74 M_PlaneDistance             ( ModelPrimitiveType float float float Single )
            value.MCanvasInfo                               = GetObjectList<CanvasInfo>(new IntPtr(p + 0x078), ReversePrism.DataModels.CanvasInfo.FromPointer); // 0x78 MCanvasInfo                 ( ModelClassListType List`1<CanvasInfo> List`1<CanvasInfo> List<CanvasInfo> Pointer )

            return value;
        }
    }
}
