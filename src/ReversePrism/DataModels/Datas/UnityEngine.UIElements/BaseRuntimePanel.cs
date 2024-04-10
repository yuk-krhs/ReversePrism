using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 160 M_SelectableGameObject                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 000 s_CurrentRuntimePanelCounter             int IL2CPP_TYPE_I4
    // 168 M_RuntimePanelCreationIndex              0001865F44E0 ModelPrimitiveType int int int Int32
    // 16C M_SortingPriority                        0001866656B0 ModelPrimitiveType float float float Single
    // 170 ResolvedSortingIndex                     0001865F2F90 ModelPrimitiveType int int int Int32
    // 178 Destroyed                                0001866792B0 ModelClassType Action Action Action Pointer
    // 180 M_StandardWorldSpaceShader               00018674C760 ModelClassType Shader Shader Shader Pointer
    // 188 M_DrawToCameras                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 190 TargetTexture                            000186656230 ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 198 PanelToWorld                             00018660DB20 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 1D8 TargetDisplay                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 008 DefaultScreenToPanelSpace                Func`2<Vector2, Vector2> IL2CPP_TYPE_GENERICINST
    // 1E0 m_ScreenToPanelSpace                     Func`2<Vector2, Vector2> IL2CPP_TYPE_GENERICINST
    public partial class BaseRuntimePanel : DataModel
    {
        public GameObject?                              M_SelectableGameObject                  { get; set; }
        public int                                      M_RuntimePanelCreationIndex             { get; set; }
        public float                                    M_SortingPriority                       { get; set; }
        public int                                      ResolvedSortingIndex                    { get; set; }
        public Action?                                  Destroyed                               { get; set; }
        public Shader?                                  M_StandardWorldSpaceShader              { get; set; }
        public bool                                     M_DrawToCameras                         { get; set; }
        public RenderTexture?                           TargetTexture                           { get; set; }
        public Matrix4x4                                PanelToWorld                            { get; set; }
        public int                                      TargetDisplay                           { get; set; }

        public static BaseRuntimePanel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseRuntimePanel() { Pointer= p0 };

            value.M_SelectableGameObject                    = GetObject<GameObject>(new IntPtr(p + 0x160), ReversePrism.DataModels.GameObject.FromPointer); // 0245A3F00A78 0x160 M_SelectableGameObject      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.M_RuntimePanelCreationIndex               = GetInt32(new IntPtr(p + 0x168)); // 0245A3F00AB8 0x168 M_RuntimePanelCreationIndex ( 0001865F44E0 ModelPrimitiveType int int int Int32 )
            value.M_SortingPriority                         = GetSingle(new IntPtr(p + 0x16C)); // 0245A3F00AD8 0x16C M_SortingPriority           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ResolvedSortingIndex                      = GetInt32(new IntPtr(p + 0x170)); // 0245A3F00AF8 0x170 ResolvedSortingIndex        ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Destroyed                                 = GetObject<Action>(new IntPtr(p + 0x178), ReversePrism.DataModels.Action.FromPointer); // 0245A3F00B18 0x178 Destroyed                   ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.M_StandardWorldSpaceShader                = GetObject<Shader>(new IntPtr(p + 0x180), ReversePrism.DataModels.Shader.FromPointer); // 0245A3F00B38 0x180 M_StandardWorldSpaceShader  ( 00018674C760 ModelClassType Shader Shader Shader Pointer )
            value.M_DrawToCameras                           = GetBool(new IntPtr(p + 0x188)); // 0245A3F00B58 0x188 M_DrawToCameras             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TargetTexture                             = GetObject<RenderTexture>(new IntPtr(p + 0x190), ReversePrism.DataModels.RenderTexture.FromPointer); // 0245A3F00B78 0x190 TargetTexture               ( 000186656230 ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.PanelToWorld                              = (Matrix4x4)GetInt32(new IntPtr(p + 0x198)); // 0245A3F00B98 0x198 PanelToWorld                ( 00018660DB20 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.TargetDisplay                             = GetInt32(new IntPtr(p + 0x1D8)); // 0245A3F00BB8 0x1D8 TargetDisplay               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
