using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ThrowMarkerContinuationQueue             ContinuationQueue IL2CPP_TYPE_CLASS
    // 008 ThrowMarkerPlayerLoopRunner              PlayerLoopRunner IL2CPP_TYPE_CLASS
    // 010 MainThreadId                             0001865F38E0 ModelPrimitiveType int int int Int32
    // 018 ApplicationDataPath                      000186672530 ModelPrimitiveType string string string String
    // 020 UnitySynchronizationContext              000186601FD0 ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer
    // 028 Yielders                                 000185B77200 ModelClassListType ContinuationQueue[] ContinuationQueue[] List<ContinuationQueue> Pointer
    // 030 Runners                                  000185B9B6E0 ModelClassListType PlayerLoopRunner[] PlayerLoopRunner[] List<PlayerLoopRunner> Pointer
    // 038 IsEditorApplicationQuitting              000186595C30 ModelPrimitiveType bool bool bool Bool
    public partial class PlayerLoopHelper
    {
        public int                                      MainThreadId                            { get; set; }
        public string                                   ApplicationDataPath                     { get; set; }
        public SynchronizationContext?                  UnitySynchronizationContext             { get; set; }
        public List<ContinuationQueue>?                 Yielders                                { get; set; }
        public List<PlayerLoopRunner>?                  Runners                                 { get; set; }
        public bool                                     IsEditorApplicationQuitting             { get; set; }

        public static PlayerLoopHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayerLoopHelper();

            value.MainThreadId                              = GetInt32(new IntPtr(p + 0x010)); // 027003BD7E78 0x10 MainThreadId                ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.ApplicationDataPath                       = GetString(new IntPtr(p + 0x018)); // 027003BD7E98 0x18 ApplicationDataPath         ( 000186672530 ModelPrimitiveType string string string String )
            value.UnitySynchronizationContext               = GetObject<SynchronizationContext>(new IntPtr(p + 0x020), ReversePrism.DataModels.SynchronizationContext.FromPointer); // 027003BD7EB8 0x20 UnitySynchronizationContext ( 000186601FD0 ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer )
            value.Yielders                                  = GetObjectList<ContinuationQueue>(new IntPtr(p + 0x028), ReversePrism.DataModels.ContinuationQueue.FromPointer); // 027003BD7ED8 0x28 Yielders                    ( 000185B77200 ModelClassListType ContinuationQueue[] ContinuationQueue[] List<ContinuationQueue> Pointer )
            value.Runners                                   = GetObjectList<PlayerLoopRunner>(new IntPtr(p + 0x030), ReversePrism.DataModels.PlayerLoopRunner.FromPointer); // 027003BD7EF8 0x30 Runners                     ( 000185B9B6E0 ModelClassListType PlayerLoopRunner[] PlayerLoopRunner[] List<PlayerLoopRunner> Pointer )
            value.IsEditorApplicationQuitting               = GetBool(new IntPtr(p + 0x038)); // 027003BD7F18 0x38 IsEditorApplicationQuitting ( 000186595C30 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
