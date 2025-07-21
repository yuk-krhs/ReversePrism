using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _providerTable                           WeakHashtable IL2CPP_TYPE_CLASS
    // 008 _providerTypeTable                       Hashtable IL2CPP_TYPE_CLASS
    // 010 DefaultProviders                         ModelClassType Hashtable Hashtable Hashtable Pointer
    // 018 AssociationTable                         ModelClassType WeakHashtable WeakHashtable WeakHashtable Pointer
    // 020 MetadataVersion                          ModelPrimitiveType int int int Int32
    // 024 CollisionIndex                           ModelPrimitiveType int int int Int32
    // 028 TraceDescriptor                          ModelClassType BooleanSwitch BooleanSwitch BooleanSwitch Pointer
    // 030 PipelineInitializeKeys                   ModelEnumListType Guid[] Guid[] List<Guid> Pointer
    // 038 PipelineMergeKeys                        ModelEnumListType Guid[] Guid[] List<Guid> Pointer
    // 040 PipelineFilterKeys                       ModelEnumListType Guid[] Guid[] List<Guid> Pointer
    // 048 PipelineAttributeFilterKeys              ModelEnumListType Guid[] Guid[] List<Guid> Pointer
    // 050 _internalSyncObject                      <object> IL2CPP_TYPE_OBJECT
    // 058 Refreshed                                ModelClassType RefreshEventHandler RefreshEventHandler RefreshEventHandler Pointer
    public partial class TypeDescriptor : DataModel
    {
        public Hashtable?                               DefaultProviders                        { get; set; }
        public WeakHashtable?                           AssociationTable                        { get; set; }
        public int                                      MetadataVersion                         { get; set; }
        public int                                      CollisionIndex                          { get; set; }
        public BooleanSwitch?                           TraceDescriptor                         { get; set; }
        public List<Guid>?                              PipelineInitializeKeys                  { get; set; }
        public List<Guid>?                              PipelineMergeKeys                       { get; set; }
        public List<Guid>?                              PipelineFilterKeys                      { get; set; }
        public List<Guid>?                              PipelineAttributeFilterKeys             { get; set; }
        public RefreshEventHandler?                     Refreshed                               { get; set; }

        public static TypeDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeDescriptor() { Pointer= p0 };

            value.DefaultProviders                          = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 0x10 DefaultProviders            ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.AssociationTable                          = GetObject<WeakHashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.WeakHashtable.FromPointer); // 0x18 AssociationTable            ( ModelClassType WeakHashtable WeakHashtable WeakHashtable Pointer )
            value.MetadataVersion                           = GetInt32(new IntPtr(p + 0x020)); // 0x20 MetadataVersion             ( ModelPrimitiveType int int int Int32 )
            value.CollisionIndex                            = GetInt32(new IntPtr(p + 0x024)); // 0x24 CollisionIndex              ( ModelPrimitiveType int int int Int32 )
            value.TraceDescriptor                           = GetObject<BooleanSwitch>(new IntPtr(p + 0x028), ReversePrism.DataModels.BooleanSwitch.FromPointer); // 0x28 TraceDescriptor             ( ModelClassType BooleanSwitch BooleanSwitch BooleanSwitch Pointer )
            value.PipelineInitializeKeys                    = GetEnumList<Guid>(new IntPtr(p + 0x030)); // 0x30 PipelineInitializeKeys      ( ModelEnumListType Guid[] Guid[] List<Guid> Pointer )
            value.PipelineMergeKeys                         = GetEnumList<Guid>(new IntPtr(p + 0x038)); // 0x38 PipelineMergeKeys           ( ModelEnumListType Guid[] Guid[] List<Guid> Pointer )
            value.PipelineFilterKeys                        = GetEnumList<Guid>(new IntPtr(p + 0x040)); // 0x40 PipelineFilterKeys          ( ModelEnumListType Guid[] Guid[] List<Guid> Pointer )
            value.PipelineAttributeFilterKeys               = GetEnumList<Guid>(new IntPtr(p + 0x048)); // 0x48 PipelineAttributeFilterKeys ( ModelEnumListType Guid[] Guid[] List<Guid> Pointer )
            value.Refreshed                                 = GetObject<RefreshEventHandler>(new IntPtr(p + 0x058), ReversePrism.DataModels.RefreshEventHandler.FromPointer); // 0x58 Refreshed                   ( ModelClassType RefreshEventHandler RefreshEventHandler RefreshEventHandler Pointer )

            return value;
        }
    }
}
