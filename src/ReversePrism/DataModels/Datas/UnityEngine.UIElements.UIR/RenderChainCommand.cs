using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Owner                                    0001866B2FC0 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 020 Prev                                     000186654740 ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer
    // 028 Next                                     000186654740 ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer
    // 030 Closing                                  000186595210 ModelPrimitiveType bool bool bool Bool
    // 034 Type                                     0001865E1B80 ModelEnumType CommandType CommandType CommandType Int32
    // 038 State                                    000186581190 ModelEnumType State State State Int32
    // 050 Mesh                                     000186611C80 ModelClassType MeshHandle MeshHandle MeshHandle Pointer
    // 058 IndexOffset                              0001865F2F90 ModelPrimitiveType int int int Int32
    // 05C IndexCount                               0001865F2F90 ModelPrimitiveType int int int Int32
    // 060 Callback                                 0001866794E0 ModelClassType Action Action Action Pointer
    // 000 k_ID_MainTex                             int IL2CPP_TYPE_I4
    // 008 s_ImmediateOverheadMarker                ProfilerMarker IL2CPP_TYPE_VALUETYPE
    public partial class RenderChainCommand
    {
        public VisualElement?                           Owner                                   { get; set; }
        public RenderChainCommand?                      Prev                                    { get; set; }
        public RenderChainCommand?                      Next                                    { get; set; }
        public bool                                     Closing                                 { get; set; }
        public CommandType                              Type                                    { get; set; }
        public State                                    State                                   { get; set; }
        public MeshHandle?                              Mesh                                    { get; set; }
        public int                                      IndexOffset                             { get; set; }
        public int                                      IndexCount                              { get; set; }
        public Action?                                  Callback                                { get; set; }

        public static RenderChainCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderChainCommand();

            value.Owner                                     = GetObject<VisualElement>(new IntPtr(p + 0x018), ReversePrism.DataModels.VisualElement.FromPointer); // 0270068632E8 0x18 Owner                       ( 0001866B2FC0 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.Prev                                      = GetObject<RenderChainCommand>(new IntPtr(p + 0x020), ReversePrism.DataModels.RenderChainCommand.FromPointer); // 027006863308 0x20 Prev                        ( 000186654740 ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer )
            value.Next                                      = GetObject<RenderChainCommand>(new IntPtr(p + 0x028), ReversePrism.DataModels.RenderChainCommand.FromPointer); // 027006863328 0x28 Next                        ( 000186654740 ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer )
            value.Closing                                   = GetBool(new IntPtr(p + 0x030)); // 027006863348 0x30 Closing                     ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.Type                                      = (CommandType)GetInt32(new IntPtr(p + 0x034)); // 027006863368 0x34 Type                        ( 0001865E1B80 ModelEnumType CommandType CommandType CommandType Int32 )
            value.State                                     = (State)GetInt32(new IntPtr(p + 0x038)); // 027006863388 0x38 State                       ( 000186581190 ModelEnumType State State State Int32 )
            value.Mesh                                      = GetObject<MeshHandle>(new IntPtr(p + 0x050), ReversePrism.DataModels.MeshHandle.FromPointer); // 0270068633A8 0x50 Mesh                        ( 000186611C80 ModelClassType MeshHandle MeshHandle MeshHandle Pointer )
            value.IndexOffset                               = GetInt32(new IntPtr(p + 0x058)); // 0270068633C8 0x58 IndexOffset                 ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.IndexCount                                = GetInt32(new IntPtr(p + 0x05C)); // 0270068633E8 0x5C IndexCount                  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Callback                                  = GetObject<Action>(new IntPtr(p + 0x060), ReversePrism.DataModels.Action.FromPointer); // 027006863408 0x60 Callback                    ( 0001866794E0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
