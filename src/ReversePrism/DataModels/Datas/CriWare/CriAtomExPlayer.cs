using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 OnBeatSyncCallback                       ModelClassType CbFunc CbFunc CbFunc Pointer
    // 028 OnSequenceCallback                       ModelClassType EventCallback EventCallback EventCallback Pointer
    // 030 HasExistingNativeHandle                  ModelPrimitiveType bool bool bool Bool
    // 038 entryPoolHandle                          <int> IL2CPP_TYPE_I
    // 040 EntryPoolCapacity                        ModelPrimitiveType int int int Int32
    // 044 Max_path                                 ModelPrimitiveType int int int Int32
    // 000 MaxOutputPorts                           uint IL2CPP_TYPE_U4
    // 048 handle                                   <int> IL2CPP_TYPE_I
    public partial class CriAtomExPlayer : DataModel
    {
        public CbFunc?                                  OnBeatSyncCallback                      { get; set; }
        public EventCallback?                           OnSequenceCallback                      { get; set; }
        public bool                                     HasExistingNativeHandle                 { get; set; }
        public int                                      EntryPoolCapacity                       { get; set; }
        public int                                      Max_path                                { get; set; }

        public static CriAtomExPlayer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomExPlayer() { Pointer= p0 };

            value.OnBeatSyncCallback                        = GetObject<CbFunc>(new IntPtr(p + 0x020), ReversePrism.DataModels.CbFunc.FromPointer); // 0x20 OnBeatSyncCallback          ( ModelClassType CbFunc CbFunc CbFunc Pointer )
            value.OnSequenceCallback                        = GetObject<EventCallback>(new IntPtr(p + 0x028), ReversePrism.DataModels.EventCallback.FromPointer); // 0x28 OnSequenceCallback          ( ModelClassType EventCallback EventCallback EventCallback Pointer )
            value.HasExistingNativeHandle                   = GetBool(new IntPtr(p + 0x030)); // 0x30 HasExistingNativeHandle     ( ModelPrimitiveType bool bool bool Bool )
            value.EntryPoolCapacity                         = GetInt32(new IntPtr(p + 0x040)); // 0x40 EntryPoolCapacity           ( ModelPrimitiveType int int int Int32 )
            value.Max_path                                  = GetInt32(new IntPtr(p + 0x044)); // 0x44 Max_path                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
