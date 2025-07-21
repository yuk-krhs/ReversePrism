using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Owner                                    ModelClassType VisualElement VisualElement VisualElement Pointer
    // 020 Prev                                     ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer
    // 028 Next                                     ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer
    // 030 Closing                                  ModelPrimitiveType bool bool bool Bool
    // 034 Type                                     ModelEnumType CommandType CommandType CommandType Int32
    // 038 State                                    ModelEnumType State State State Int32
    // 050 Mesh                                     ModelClassType MeshHandle MeshHandle MeshHandle Pointer
    // 058 IndexOffset                              ModelPrimitiveType int int int Int32
    // 05C IndexCount                               ModelPrimitiveType int int int Int32
    // 060 Callback                                 ModelClassType Action Action Action Pointer
    // 000 k_ID_MainTex                             int IL2CPP_TYPE_I4
    // 008 s_ImmediateOverheadMarker                ProfilerMarker IL2CPP_TYPE_VALUETYPE
    public partial class RenderChainCommand : DataModel
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
            var value   = new RenderChainCommand() { Pointer= p0 };

            value.Owner                                     = GetObject<VisualElement>(new IntPtr(p + 0x018), ReversePrism.DataModels.VisualElement.FromPointer); // 0x18 Owner                       ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.Prev                                      = GetObject<RenderChainCommand>(new IntPtr(p + 0x020), ReversePrism.DataModels.RenderChainCommand.FromPointer); // 0x20 Prev                        ( ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer )
            value.Next                                      = GetObject<RenderChainCommand>(new IntPtr(p + 0x028), ReversePrism.DataModels.RenderChainCommand.FromPointer); // 0x28 Next                        ( ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer )
            value.Closing                                   = GetBool(new IntPtr(p + 0x030)); // 0x30 Closing                     ( ModelPrimitiveType bool bool bool Bool )
            value.Type                                      = (CommandType)GetInt32(new IntPtr(p + 0x034)); // 0x34 Type                        ( ModelEnumType CommandType CommandType CommandType Int32 )
            value.State                                     = (State)GetInt32(new IntPtr(p + 0x038)); // 0x38 State                       ( ModelEnumType State State State Int32 )
            value.Mesh                                      = GetObject<MeshHandle>(new IntPtr(p + 0x050), ReversePrism.DataModels.MeshHandle.FromPointer); // 0x50 Mesh                        ( ModelClassType MeshHandle MeshHandle MeshHandle Pointer )
            value.IndexOffset                               = GetInt32(new IntPtr(p + 0x058)); // 0x58 IndexOffset                 ( ModelPrimitiveType int int int Int32 )
            value.IndexCount                                = GetInt32(new IntPtr(p + 0x05C)); // 0x5C IndexCount                  ( ModelPrimitiveType int int int Int32 )
            value.Callback                                  = GetObject<Action>(new IntPtr(p + 0x060), ReversePrism.DataModels.Action.FromPointer); // 0x60 Callback                    ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
